using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.CRM.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class CustomerWaybillTrackAndTraceModel

    {
        public List<CustomerWaybillTrackAndTraceModel> CustomerWaybillTrackAndTraceModels { get; set; }
        public List<CustomerWaybillTrackandTrace> CustomerWaybillTrackandTrace { get; set; }
        public List<FWEventCodes> FwEventCodes { get; set; }
        public WaybillTrackandTraces WaybillTrackandTraces { get; set; }

    }
}
