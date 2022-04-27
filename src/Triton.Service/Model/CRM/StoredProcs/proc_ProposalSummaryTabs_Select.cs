using Triton.Model.CRM.Tables;

namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_ProposalSummaryTabs_Select
    {
        public Customers Customers { get; set; }
        public WorkFlowManager WorkFlowManager { get; set; }
        public CustomerAnalysis CustomerAnalysis { get; set; }
    }
}
