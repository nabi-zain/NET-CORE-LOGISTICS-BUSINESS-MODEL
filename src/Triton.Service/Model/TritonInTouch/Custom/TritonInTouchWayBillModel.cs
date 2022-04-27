using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonOps.StoredProcs;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonOps.Views;
using Triton.Model.TritonStaging.StoredProcs;

namespace Triton.Model.TritonInTouch.Custom
{
   public class TritonInTouchWayBillModel
    {
        public List<vwOpsWaybills> VwOpsWaybills { get; set; }
        public List<Waybills> Waybills { get; set; }
        public List<proc_FMOEndorsements_Signature_Select> ProcFmoEndorsementsSignatureSelect { get; set; }
        public List<proc_Waybills_Grid_Select> ProcWaybillsGridSelect { get; set; }
        public List<WaybillOpsNotes> WaybillOpsNotes { get; set; }
        public List<proc_Waybills_TransportType_Select> ProcWaybillsTransportTypeSelect { get; set; }
        public List<proc_WaybillTrackandTraces_CustomerDesc_Select> ProcWaybillTrackandTracesCustomerDescSelect { get; set; }
        public List<WayBillDetail> WayBillDetail { get; set; }
        public List<proc_CSA_Waybills_Select> ProcCsaWaybillsSelect { get; set; }

    }
}
