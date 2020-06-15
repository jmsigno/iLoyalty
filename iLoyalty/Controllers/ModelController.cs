using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Google.Cloud.BigQuery.V2;
using Google.Apis.Bigquery.v2.Data;
using iLoyalty.Models;
using System.Text;

namespace iLoyalty.Controllers
{

    public class ModelController : Controller
    {
        private List<BigQModel> bigQModels;
        public IActionResult Index()
        {
            List<CBoxes> cb = new List<CBoxes>()
            {
                new CBoxes
                {
                    boxId=1, boxName="state"
                },
                new CBoxes
                {
                    boxId=2, boxName="account_length"
                },
                new CBoxes
                {
                    boxId=3, boxName="area_code"
                },
                new CBoxes
                {
                    boxId=4, boxName="international_plan"
                },
                new CBoxes
                {
                    boxId=5, boxName="voice_mail_plan"
                },
                new CBoxes
                {
                    boxId=6, boxName="number_vmail_messages"
                },
                new CBoxes
                {
                    boxId=7, boxName="total_day_minutes"
                },
                new CBoxes
                {
                    boxId=8, boxName="total_day_calls"
                },
                new CBoxes
                {
                    boxId=9, boxName="total_day_charge"
                },
                new CBoxes
                {
                    boxId=9, boxName="total_eve_minutes"
                },
                new CBoxes
                {
                    boxId=10, boxName="total_eve_calls"
                },
                new CBoxes
                {
                    boxId=11, boxName="total_eve_charge"
                },
                new CBoxes
                {
                    boxId=12, boxName="total_night_minutes"
                },
                new CBoxes
                {
                    boxId=13, boxName="total_night_calls"
                },
                new CBoxes
                {
                    boxId=14, boxName="total_night_charge"
                },
                new CBoxes
                {
                    boxId=15, boxName="total_intl_minutes"
                },
                new CBoxes
                {
                    boxId=16, boxName="total_intl_calls"
                },
                new CBoxes
                {
                    boxId=17, boxName="total_intl_charge"
                },
                new CBoxes
                {
                    boxId=18, boxName="customer_service_calls"
                },
            };

            CBoxList cbl = new CBoxList();
            cbl.cboxlist = cb;

            return View(cbl);
        }

        [HttpPost]
        public async Task<IActionResult> Index(CBoxList cblist, string name)
        {
            try
            {
                StringBuilder _schema = new StringBuilder();
                foreach (var item in cblist.cboxlist)
                {
                    if (item.isChecked)
                    {
                        _schema.Append(item.boxName + ", ");
                    }
                }

            var client = await BigQueryClient.CreateAsync("iloyalty");
            string mlConfig = "model_type = 'LOGISTIC_REG', auto_class_weights = TRUE, input_label_cols =['churn'], max_iterations = 50";
            string sql = @"CREATE OR REPLACE MODEL `iloyalty.telco_db."+name+"` OPTIONS ("+mlConfig+") AS SELECT " + _schema + "churn FROM `iloyalty.telco_db.test_view3` WHERE dataframe = 'training'";
            await client.ExecuteQueryAsync(sql, parameters: null);
            }
            catch(Exception e)
            {
                ViewBag.msg = e.Message.ToString();
                return View(cblist);
            }
            ViewBag.msg = name + "model created!";
            return View(cblist);
        }
        public IActionResult DataSet()
        {
            bigQModels = new List<BigQModel>();
            var client = BigQueryClient.Create("iloyalty");
            var table = client.GetTable("iloyalty", "telco_db", "customers");
            var sql = $"SELECT * FROM {table} WHERE state='NY'";
            var results = client.ExecuteQuery(sql, parameters: null);

            foreach (var row in results)
            {
                bigQModels.Add(
                    new BigQModel(
                        row["phone_number"].ToString(),
                        row["state"].ToString(),
                        row["account_length"].ToString(),
                        row["area_code"].ToString(),
                        (bool)row["international_plan"],
                        (bool)row["voice_mail_plan"],
                        row["number_vmail_messages"].ToString(),
                        row["customer_service_calls"].ToString(),
                        (bool)row["churn"]));
            }
            return View(bigQModels);
        }

        #region
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<BigQModel> bigQResults = new List<BigQModel>();

            var client = BigQueryClient.Create("iloyalty");
            var table = await client.GetTableAsync("iloyalty", "telco_db", "customers");
            var sql = $"SELECT * FROM {table} WHERE state='NY'";
            var results = await client.ExecuteQueryAsync(sql, parameters: null);
            
            foreach(var row in results)
            {
                bigQResults.Add(
                    new BigQModel(
                        row["phone_number"].ToString(),
                        row["state"].ToString(),
                        row["account_length"].ToString(),
                        row["area_code"].ToString(),
                        (bool)row["international_plan"],
                        (bool)row["voice_mail_plan"],
                        row["number_vmail_messages"].ToString(),
                        row["customer_service_calls"].ToString(),
                        (bool)row["churn"]));
            } 

            return Json(new { data = bigQResults.ToList()});
        }
        #endregion

        //[HttpPost]
        //public IActionResult Index(CBoxList cblist, string name)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var item in cblist.cboxlist)
        //    {
        //        if (item.isChecked)
        //        {
        //            sb.Append(item.boxName + "', '");
        //        }
        //    }
        //    ViewBag.name = name;
        //    ViewBag.msg = sb + " " + name; 
        //    return View(cblist);
        //}
    }
}


