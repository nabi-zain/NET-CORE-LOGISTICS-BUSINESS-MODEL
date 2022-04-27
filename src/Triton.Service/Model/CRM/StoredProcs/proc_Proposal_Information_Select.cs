using System.Collections.Generic;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.CRM.Tables;

namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_Proposal_Information_Select
    {
        public CustomerAnalysis CustomerAnalysis { get; set; }
        public Customers Customers { get; set; }
        public CustomerStatuss CustomerStatuss { get; set; }
        public CustomerAccountTypes CustomerAccountTypes { get; set; }
        public WorkFlowStages WorkFlowStages { get; set; }
        public List<WorkFlowTasks> WorkFlowTasks { get; set; }
        public RepCodes RepCodes { get; set; }
        public Branches Branches { get; set; }
        public WorkFlowManager WorkFlowManager { get; set; }
        public RateIncreases RateIncreases { get; set; }
    }
}
