using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("SalaryEmpMap")]
    public class SalaryEmpMap
    {
        [Key]
        public int ID { get; set; }
        public int? UserID { get; set; }
        public int? EmpID { get; set; }
        public string IsComplete { get; set; }
        public int? DocumentID { get; set; }
        public int? SalaryCaptureID { get; set; }
        public int? GroupID { get; set; }
    }
}
