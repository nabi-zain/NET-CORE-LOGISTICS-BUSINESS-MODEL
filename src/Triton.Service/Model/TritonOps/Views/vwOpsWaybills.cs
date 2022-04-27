using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.Views
{

    public class vwOpsWaybills
    {
        public long WaybillID { get; set; }
        public string WaybillNo { get; set; }
        public string CustomerName { get; set; }
        public DateTime WaybillDate { get; set; }
        public DateTime? InvoiceDate { get; set; }
    }
}
