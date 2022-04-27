using System;
using System.Collections.Generic;
using Triton.Service.Model.CRM.Tables;
using Triton.Service.Model.TritonGroup.Custom;

namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_CustomerSummary
    {
        public List<Customers_WorkFlowManager> CustomersSummaryList { get; set; }
        public List<WorkFlowStagesModel> WorkFlowStagesList { get; set; }
        public List<RateCycles> RateCyclesList { get; set; }
    }

    public class Customers_WorkFlowManager
    {
        public int CustomerID { get; set; }
        public string AccountCode { get; set; }
        public string Name { get; set; }
        public string BranchFullName { get; set; }
        public string FWRateAccCode { get; set; }
        public bool HasUnique { get; set; }
        public int CustomerAnalysisID { get; set; }
        public string RepName { get; set; }
        public int RateIncreaseID { get; set; }
        public int UserID { get; set; }
        public int WorkID { get; set; }
        public int? RecordID { get; set; }
        public int? StageID { get; set; }
        public int? AssignedtoID { get; set; }
        public int? TaskID { get; set; }
        public DateTime? WorkDate { get; set; }
        public string Comments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? WorkFlowID { get; set; }
        public string KeyName { get; set; }
        public bool IsChecked { get; set; }
    }
}
