using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("EmployeeJob")]
    public class EmployeeJob
    {
        [Key]
        public int ID { get; set; }
        public int? EmployeeID { get; set; }
        public int? JobID { get; set; }
        public int? JobGradeID { get; set; }
    }
}
