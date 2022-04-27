using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("EmployeeLog")]
    public class EmployeeLog
    {
        [Key]
        public int LogID { get; set; }
        public int? LogTypeID { get; set; }
        public int? EmployeeID { get; set; }
        public int? CreatorEmployeeID { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
