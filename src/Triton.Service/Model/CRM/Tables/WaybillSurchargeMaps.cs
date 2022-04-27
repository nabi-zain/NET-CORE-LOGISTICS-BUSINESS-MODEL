using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    public class WaybillSurchargeMaps
    {
        public int WaybillSurchargeMapID { get; set; }
        public int WaybillID { get; set; }
        public int WaybillSurchargeID { get; set; }
        public decimal SurchargeAmt { get; set; }
    }
}
