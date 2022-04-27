using Triton.Model.Applications.Tables;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class DeliveriesSubContractorRequests
    {
        #region Properties

        public TritonLH.Tables.Customers Customers { get; set; }
        public Deliveries Deliveries { get; set; }
        public Sites FromSite { get; set; }
        public SubContractorRequests SubContractorRequests { get; set; }
        public Sites ToSite { get; set; }
        public tblMasterSuppliers tblMasterSuppliers { get; set; }
        public TritonGroup.Tables.Users Users { get; set; }

        #endregion Properties
    }

    public class SubContractorRequestsTotals
    {
        #region Properties

        public string Detail { get; set; }
        public int Total { get; set; }

        #endregion Properties
    }

    public class SubContractorRequests_And_WorkFlowManager
    {
        #region Properties

        public SubContractorRequests SubContractorRequests { get; set; }
        public TritonGroup.Tables.WorkFlowManager WorkFlowManager { get; set; }

        #endregion Properties
    }
}
