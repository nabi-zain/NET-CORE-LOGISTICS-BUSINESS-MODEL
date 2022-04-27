using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    public class WaybillSurcharges
    {
        public int WaybillSurchargeID { get; set; }
        public string SundryChargeFWCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public string DropDownText { get { return SundryChargeFWCode + " - " + Description; } }
    }
}
