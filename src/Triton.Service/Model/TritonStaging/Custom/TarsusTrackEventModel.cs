using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;

namespace Triton.Model.TritonStaging.Custom
{
    public class TarsusTrackEventModel
    {
        public List<CustomerWaybillTrackandTrace> Tracks { get; set; }
        public Waybills Waybill { get; set; }
        public Customers Customer { get; set; }
        public string ShippingID { get; set; }
    }
}
