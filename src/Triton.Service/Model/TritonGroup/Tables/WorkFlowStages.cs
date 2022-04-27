namespace Triton.Model.TritonGroup.Tables
{
    public class WorkFlowStages
    {
        public int WorkFlowStageID { get; set; }
        public string WorkFlowStage { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public int? OrderBy { get; set; }
        public string IconName { get; set; }
        public string StageHelp { get; set; }
        public string ExceptionString { get; set; }
    }
}
