using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("WorkFlowTasks")]

    public class WorkFlowTasks
    {
        [Key]
        public int WorkFlowTaskID { get; set; }
        public int? WorkFlowStageID { get; set; }
        public string WorkFlowTask { get; set; }
        public int? FlowID { get; set; }
        public int? SendNotification { get; set; }
        public int? Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public string Icon { get; set; }
        public int? RoleID { get; set; }
    }
}
