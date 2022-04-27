using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Triton.Model.TritonOps.Tables
{
    [Table("WorkflowTasks")]
    public class WorkflowTasks
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]

        public int WorkFlowTaskID { get; set;}

        public int WorkFlowStageID { get; set; }

        public string WorkFlowTask { get; set; }

        public int FlowID { get; set; }

        public int SendNotification { get; set; }

        public int Status { get; set; }

        public DateTime? StatusDate { get; set; }

        public string Icon { get; set; }
    }
}
