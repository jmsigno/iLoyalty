using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace iLoyalty.Models
{
    public class BigQModel
    {
        public BigQModel()
        {

        }
        public BigQModel(string x, string a, string b, string c, bool d, bool e, string f, string g, bool h )
        {
            this.phone = x;
            this.state = a;
            this.acctLength = b;
            this.areaCode = c;
            this.intlPlan = d;
            this.vmPlan = e;
            this.vmailMsg = f;
            this.custServCalls = g;
            this.churn = h;
        }

        public string phone { get; set; }
        public string state { get; set; }
        public string acctLength { get; set; }
        public string areaCode { get; set; }
        public bool intlPlan { get; set; }
        public bool vmPlan { get; set; }
        public string vmailMsg { get; set; }
        public string custServCalls { get; set; }
        public bool churn { get; set; }

    }
}
