namespace Triton.Service.Model.TritonGroup.Custom
{
    public class WorkFlowStagesModel
    {
        public int WorkFlowStageID { get; set; }
        public string WorkFlowStage { get; set; }
        public string WorkFlowPageName { get; set; }
        public int ? OrderBy { get; set; }
        public string IconName { get; set; }
        public string StageHelp { get; set; }
        public int ? WorkFlowID { get; set; }
        public int CustomersCounts { get; set; }
        public int Total { get; set; }

    }
}
