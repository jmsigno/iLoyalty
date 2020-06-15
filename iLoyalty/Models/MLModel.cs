using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iLoyalty.Models
{
    public class MLModel
    {
        public int id { get; set; }
        public string model_name { get; set; }
        public string creator { get; set; }
        public string date_created { get; set; }
        public string predict_query { get; set; }

    }
}
