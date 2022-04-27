namespace Triton.Service.Model.TritonGroup.StoredProcs
{
    public class proc_Customers_SalesRep_WorkStage
    {
        public string Customer { get; set; }
        public string CustomerAnalysisID { get; set; }
        public string Name { get; set; }
        public int Analysis { get; set; }
        public int OpsAnalysis { get; set; }
        public int OpsApproval { get; set; }
        public int Parking { get; set; }
        public int UniqueApproval { get; set; }
        public int ApprovedIncrease { get; set; }
        public int OntheRoad { get; set; }
        public int CaptureIncreases { get; set; }
        public int Completed { get; set; }
        public int Approval { get; set; }
        public int SalesRep { get; set; }
        public string AccountCode { get; set; }
        public int RateIncreaseID { get; set; }
        public string WorkFlowStageID { get; set; }
        public int WorkFlowID { get; set; }
        public string FWCreditController { get; set; }
    }
}
