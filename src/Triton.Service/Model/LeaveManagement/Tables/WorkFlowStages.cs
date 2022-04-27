using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{

    [Table("WorkFlowStages")]
    public class WorkFlowStage
    {
        [Key]
        public int WorkFlowStageID { get; set; }
        
        public string WorkFlowStages { get; set; }
        public string WorkFlowPageName { get; set; }
        public int? RecordId { get; set; }
        public int? AssignedtoId { get; set; }
        public int? TaskId { get; set; }
        public int? UserId { get; set; }
        public DateTime? WorkDate { get; set; }
        public string Comments { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
