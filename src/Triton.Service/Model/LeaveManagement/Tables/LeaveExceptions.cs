using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveExceptions")]
    public class LeaveExceptions
    {
        [Key]
        public int LeaveExceptionID{ get; set; }
        public int? VipLeaveID { get; set; }
        public int? HrLeaveID { get; set; }
        public DateTime ClearedOnDate { get; set; }
        public string Reason { get; set; }
    }
}
