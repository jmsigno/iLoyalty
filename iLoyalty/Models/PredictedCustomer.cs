using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iLoyalty.Models
{
    public class PredictedCustomer
    {
        public PredictedCustomer()
        {
           
        }
        public PredictedCustomer(string _name, string _address, string _phone, string _email, string _churn)
        {
            this.name = _name;
            this.address = _address;
            this.phone_number = _phone;
            this.email = _email;
            this.predicted_churn = _churn;
        }

        public string name { get; set; }
        public string address { get; set; }
        public string phone_number { get; set; }
        public string email { get; set; }
        public string predicted_churn { get; set; }
        public List<PredictedCustomer> predictedCustomers { get; set; }
    }
}
