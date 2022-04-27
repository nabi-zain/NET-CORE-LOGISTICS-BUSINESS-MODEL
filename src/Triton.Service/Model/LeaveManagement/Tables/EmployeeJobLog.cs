using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("EmployeeJobLog")]
   public class EmployeeJobLog
    {
        public long ID { get; set; }
        public string ChangeType { get; set; }
        public int? EmployeeID { get; set; }
        public int? JobID { get; set; }
        public DateTime TimeDateStamp { get; set; }
    }
}
