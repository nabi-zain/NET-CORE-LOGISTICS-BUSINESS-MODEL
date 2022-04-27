using System;

namespace Triton.Model.TritonGroup.Tables
{
    public class WorkflowTasks
    {
        public int WorkFlowTaskID { get; set; }
        public string WorkFlowTask { get; set; }
        public int? NextWorkFlowStageID { get; set; }
        public int? SendNotification { get; set; }
        public int? Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public string Icon { get; set; }
    }
}
