using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iLoyalty.Models;
using Microsoft.AspNetCore.Mvc;
using Google.Cloud.BigQuery.V2;

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
            ViewBag.predictMsg = id;
            return View(getDdl());
        }

        private MLModel getDdl()
        {
            MLModel ml = new MLModel();

            var client = BigQueryClient.Create("iloyalty");
            string sql = @"SELECT * from `iloyalty.telco_db.models`";
            var results = client.ExecuteQuery(sql, parameters: null);

            ml.ListModels = new List<MLModel>();
            foreach (var row in results)
            {
                ml.ListModels.Add(new MLModel((int)(long)row["id"], row["model_name"].ToString()));
            }

            return ml;
        }

    }
}
