using System.Collections.Generic;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Model.CRM.Views;
using Triton.Model.TritonOps.StoredProcs;

namespace Triton.Model.TritonOps.Custom
{
    public class CustomerWaybills
    {
        public List<proc_WaybillTrackAndTraceCustomer> WaybillTrackAndTraceCustomer { get; set; }
        public List<WaybillTrackandTracesModel> WaybillTrackandTraces { get; set; }
        public vwOpsWaybills VwOpsWaybill{ get; set; }
        public List<FWEventCodes> FwEventCodes { get; set; }
        public string waybillNo { get; set; }
        public string customerXRef { get; set; }
        public int WaybillId { get; set; }
    }
}
