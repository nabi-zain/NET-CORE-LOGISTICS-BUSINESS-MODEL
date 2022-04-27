using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("WorkFlowManager")]
    public class WorkFlowManager
    {
        [Key]
        public int WorkID { get; set; }
        public int? RecordID { get; set; }
        public int? StageID { get; set; }
        public int? AssignedtoID { get; set; }
        public int? AssignedtoIDTaskID { get; set; }
        public int? UserID { get; set; }
        public DateTime? WorkDate { get; set; }
        public string Comments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? WorkFlowID { get; set; }
    }
}
