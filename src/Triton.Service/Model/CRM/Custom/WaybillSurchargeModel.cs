using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Custom
{
    public class WaybillSurchargeModel
    {
        public long WaybillSurchargeMapID { get; set; }
        public long WaybillID { get; set; }
        public decimal SurchargeAmt { get; set; }
        public int WaybillSurchargeID { get; set; }
        public string SundryChargeFWCode { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}
