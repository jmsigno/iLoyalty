using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using iLoyalty.Models;
using Google.Cloud.BigQuery.V2;
using Google.Apis.Bigquery.v2.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace iLoyalty.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Index()
        {
            //List<MLModel> allmodels = new List<MLModel>();
            //var client = BigQueryClient.Create("iloyalty");
            //string sql = @"SELECT * from `iloyalty.telco_db.models`";
            //var results = client.ExecuteQuery(sql, parameters: null);

            //foreach (var row in results)
            //{
            //    allmodels.Add(new MLModel((int)(long)row["id"], row["model_name"].ToString()));
            //}

            //var x = allmodels.Select(c => new SelectListItem
            //{
            //    Value = c.id.ToString(),
            //    Text = c.model_name.ToString(),
            //    Selected = c.id.Equals(3)
            //});

            ////var model = new ModelList
            ////{
            ////    List = x.AsEnumerable()
            ////};

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
