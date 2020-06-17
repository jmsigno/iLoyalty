using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iLoyalty.Models;
using Microsoft.AspNetCore.Mvc;
using Google.Cloud.BigQuery.V2;
using Microsoft.AspNetCore.Session;

namespace iLoyalty.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View(getDdl());
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            string name = "";
            string creator = "";
            string date = "";
            var client = BigQueryClient.Create("iloyalty");

            string namesql = @"SELECT model_name, creator, date_created from `iloyalty.telco_db.models` WHERE id="+id+"";
            var nameResult = client.ExecuteQuery(namesql, parameters: null);
            foreach (var row in nameResult)
            {
                name = row["model_name"].ToString();
                creator = row["creator"].ToString();
                date = row["date_created"].ToString();

                break;
            }

            string sql = @"UPDATE `iloyalty.telco_db.default_model` SET model_id="+id+", model_name='"+name+"' WHERE id=0";
            var results = client.ExecuteQuery(sql, parameters: null);
            
            ViewBag.SelectedModelID = id;
            ViewBag.SelectedModelName = name;
            ViewBag.SelectedModelCreator = creator;
            ViewBag.SelectedModelDate = date;
            return View(getDdl());
        }

        [HttpGet]
        public async Task<IActionResult> Predict()
        {
            PredictedCustomer pc = new PredictedCustomer();
            string name = "";
            
            var client = BigQueryClient.Create("iloyalty");
            string namesql = @"SELECT model_name from `iloyalty.telco_db.default_model` WHERE id=0";
            var nameResult = await client.ExecuteQueryAsync(namesql, parameters: null);
            foreach (var row in nameResult)
            {
                name = row["model_name"].ToString();
                break;
            }

            string sql = @"SELECT detail.*, test.predicted_churn FROM ML.PREDICT (MODEL `telco_db."+name+"`, ( SELECT * FROM `telco_db.test_view3` )) AS test INNER JOIN `telco_db.customer_details` as detail ON test.phone_number = detail.phone_number WHERE test.predicted_churn=true";
            var results = await client.ExecuteQueryAsync(sql, parameters: null);

            pc.predictedCustomers = new List<PredictedCustomer>();
            foreach (var row in results)
            {
                pc.predictedCustomers.Add(
                    new PredictedCustomer(
                        row["name"].ToString(),
                        row["address"].ToString(),
                        row["phone_number"].ToString(),
                        row["email"].ToString(),
                        row["predicted_churn"].ToString()));
            }
            return Json(new { data = pc.predictedCustomers });
        }
        private MLModel getDdl()
        {
            MLModel dbml = new MLModel();

            var client = BigQueryClient.Create("iloyalty");
            string sql = @"SELECT * from `iloyalty.telco_db.models`";
            var results = client.ExecuteQuery(sql, parameters: null);

            dbml.ListModels = new List<MLModel>();
            foreach (var row in results)
            {
                dbml.ListModels.Add(new MLModel((int)(long)row["id"], row["model_name"].ToString()));
            }
            return dbml;
        }

    }
}
