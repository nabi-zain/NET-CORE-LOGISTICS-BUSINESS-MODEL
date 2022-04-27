using System.Collections.Generic;
using Triton.Service.Model.CRM.Tables;

namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_CustomersIncreaseSummary
    {
        public List<CustomersIncreases> CustomersIncreases { get; set; }
        public RateIncreases RateIncreases { get; set; }
    }

    public class CustomersIncreases
    {
        public int CustomerID { get; set; }
        public int CustomerAnalysisID { get; set; }
        public string AccountCode { get; set; }
        public string Name { get; set; }
        public string FWRateAccCode { get; set; }
        public string FWRepCode { get; set; }
        public int BranchID { get; set; }
        public string BranchFullName { get; set; }
        public bool HasUniques { get; set; }
        public int UserID { get; set; }
        public string RepName { get; set; }
        public string Ref { get; set; }
        public string OpsNote { get; set; }
        public string OutCome { get; set; }
        public bool ProcessCompleted { get; set; }
        public bool IsChecked { get; set; }
    }
}

