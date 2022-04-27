using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("WorkFlowTaskMap")]
    public class WorkFlowTaskMap
    {
        [Key]
        public int ID { get; set; }
        public int? WorkFlowTaskID { get; set; }
        public int? RoleID { get; set; }
        public int? StageID { get; set; }
    }
}
