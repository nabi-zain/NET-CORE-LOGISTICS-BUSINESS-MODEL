using System;

namespace Triton.Service.Model.TritonGroup.Custom
{
    public class WorkflowTasksModel
    {
        public int WorkFlowTaskID { get; set; }
        public int WorkFlowStageID { get; set; }
        public string WorkFlowTask { get; set; }
        public int ? FlowID { get; set; }
        public int ? SendNotification { get; set; }
        public int ? Status { get; set; }
        public DateTime ? StatusDate { get; set; }
        public string Icon { get; set; }
        public int ? NextWorkFlowStageID { get; set; }
    }
}
