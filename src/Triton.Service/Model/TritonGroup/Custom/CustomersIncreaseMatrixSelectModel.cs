using System.Collections.Generic;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.TritonGroup.StoredProcs;


namespace Triton.Service.Model.TritonGroup.Custom
{
    public class CustomersIncreaseMatrixSelectModel
    {
        public proc_Increase_Matrix_Select_Model proc_Increase_Matrix_Select { get; set; }
        public proc_Customers_SalesRep_WorkStage proc_Customers_SalesRep_WorkStage { get; set; }
        public List<proc_Customers_SalesRep_WorkStage> proc_Customers_SalesRep_WorkStagesList { get; set; }
        public List<WorkFlowStagesModel> OverViewTabsList { get; set; }
        public List<Branches> BranchesList { get; set; }
        public List<RepCodesModel> RepCodesList { get; set; }
        public int BranchID { get; set; }
        public int UserID { get; set; }
        public List<WorkFlowStagesModel> WorkFlowStagesList { get; set; }
    }

}
