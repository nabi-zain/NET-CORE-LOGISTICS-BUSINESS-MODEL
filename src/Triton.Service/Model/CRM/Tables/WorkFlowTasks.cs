using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("WorkFlowTasks")]
    public class WorkFlowTasks
    {
        [Key]
        public int WorkFlowTaskID { get; set; }
        public int WorkFlowStageID { get; set; }
        public string WorkFlowTask { get; set; }
        public int FlowID { get; set; }
        public int SendNotification { get; set; }
        public int? Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public string Icon { get; set; }
        public int NextWorkFlowStageID { get; set; }
    }
}
