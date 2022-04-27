using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.CRM.Tables;
using Triton.Model.CRM.Views;
using Triton.Model.TritonExpress.StoredProcs;
using Triton.Model.TritonExpress.Tables;
using Triton.Model.TritonOps.StoredProcs;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonStaging.StoredProcs;
using vwOpsWaybills = Triton.Model.TritonOps.Views.vwOpsWaybills;

namespace Triton.Model.TritonInTouch.Custom
{
    public class TouchInTouchMenuModel
    {
        public List<proc_CSA_Branch_Customer_Select> CsaBranchCustomerSelect { get; set; }//
        public List<proc_Customer_By_CustomerID_Tabs_Select> ProcCustomerByCustomerIdTabsSelect { get; set; }//
        public List<proc_CSA_Customer_Select> ProcCsaCustomerSelect { get; set; }//
        public List<proc_CSA_External_Customer_Select> ProcCsaExternalCustomerSelect { get; set; }//
        public List<proc_CSA_Waybills_Select> ProcCsaWaybillsSelect { get; set; }//
        public List<WayBillDetail> WayBillDetail { get; set; }//
        public List<proc_WaybillTrackandTraces_CustomerDesc_Select> ProcWaybillTrackandTracesCustomerDescSelect { get; set; }
        public List<Customers> Customers { get; set; }//
        public List<proc_Waybills_TransportType_Select> ProcWaybillsTransportTypeSelect { get; set; }
        public List<Waybills> Waybills { get; set; }//
        public List<CSA> Csa { get; set; }//
        public List<WaybillOpsNotes> WaybillOpsNotes { get; set; }
        public List<proc_Waybills_Grid_Select> ProcWaybillsGridSelect { get; set; }

        public List<proc_FMOEndorsements_Signature_Select> ProcFmoEndorsementsSignatureSelect { get; set; }//
        public List<TransportTypes> TransportTypes { get; set; }
        public List<proc_PostalCodes_ByName_Select> ProcPostalCodesByNameSelect { get; set; }
        public List<PostalCodes> PostalCodes { get; set; }//
        public List<vwOpsWaybills> VwOpsWaybills{ get; set; }//


    }
}
