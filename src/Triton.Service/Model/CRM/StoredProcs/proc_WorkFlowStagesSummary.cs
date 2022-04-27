using System.Collections.Generic;
using Triton.Service.Model.CRM.Tables;
using Triton.Service.Model.TritonGroup.Custom;

namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_WorkFlowStagesSummary
    {
        public List<CustomerDetails> CustomerDetails { get; set; }
        public List<WorkFlowStagesModel> WorkFlowStagesList { get; set; }
        public List<RateCycles> RateCyclesList { get; set; }
        public int RateCycleID { get; set; }
    }

    public class CustomerDetails
    {
        public int CustomerID { get; set; }
        public string AccountCode { get; set; }
        public string BranchFullName { get; set; }
        public string FWRateAccCode { get; set; }
        public string Name { get; set; }
        public bool HasUnique { get; set; }
        public int CustomerAnalysisID { get; set; }
        public string RepName { get; set; }
        public int RateIncreaseID { get; set; }
        public int UserID { get; set; }
        public int StageID { get; set; }
        public bool IsChecked { get; set; }
        public int LinkedCustomerID { get; set; }
        public string ShortDescription { get; set; }
        public int CustomerStatusID { get; set; }
        public string Colour { get; set; }
        public string FWCreditController { get; set; }
    }
}
