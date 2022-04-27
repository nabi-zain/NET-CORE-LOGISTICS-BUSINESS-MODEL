using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("Admin")]
    public class Admin
    {
        public string PayCode { get; set; }
        public string DeptCode { get; set; }
        public string EmpCode { get; set; }
        public string FullNames { get; set; }
        public string Surname { get; set; }
        public DateTime? DateEngaged { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string EmployeeStatus { get; set; }
    }
}
