using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iLoyalty.Models
{
    public class MLModel
    {
        public MLModel()
        {
        }
        public MLModel(int _id, string _name) 
        {
            this.id = _id;
            this.model_name = _name;
        }
        public int id { get; set; }
        public string model_name { get; set; }
        public string creator { get; set; }
        public string date_created { get; set; }
        public string predict_query { get; set; }

        public List<MLModel> ListModels { get; set; }
    }
}
