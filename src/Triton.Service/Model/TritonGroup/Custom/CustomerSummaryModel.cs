using System.Collections.Generic;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.CRM.Tables;
using Triton.Service.Model.TritonGroup.StoredProcs;

namespace Triton.Service.Model.TritonGroup.Custom
{
    public class CustomerSummaryModel
    {
        public CustomersModel CustomersModel { get; set; }
        public WorkFlowManagerModel WorkFlowManagerModel { get; set; }
        public RateIncreases RateIncreases { get; set; }
        public List<CustomersModel> CustomersModelList { get; set; }
        public List<WorkflowTasksModel> WorkflowTasksList { get; set; }
        public List<WorkFlowStagesModel> WorkFlowStagesList { get; set; }
        public List<proc_Customers_SalesRep_WorkStage> proc_Customers_SalesRep_WorkStagesList { get; set; }
        public List<WorkFlowStagesModel> OverViewTabsList { get; set; }
        public List<Branches> BranchesList { get; set; }
        public List<RepCodesModel> RepCodesList { get; set; }
        public int BranchID { get; set; }
        public int UserID { get; set; }
        public int RateCycleID { get; set; }
        public int WorkFlowID { get; set; }
        public int WorkFlowStageID { get; set; }
        public List<RateCycles> RateCyclesList { get; set; }
        public string ProposalUrl { get; set; }
        public string RateIncreasePeriod { get; set; }
        public string AccountCode { get; set; }
    }

}
