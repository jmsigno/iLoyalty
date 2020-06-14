using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iLoyalty.Models
{
    public class CBoxes
    {
        public int boxId { get; set; }
        public string boxName { get; set; }
        public bool isChecked { get; set; }

    }

    public class CBoxList
    {
        public List<CBoxes> cboxlist { get; set; }
    }
}
