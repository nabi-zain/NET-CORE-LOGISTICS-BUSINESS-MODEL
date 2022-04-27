using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("ScReport")]
    public class ScReport
    {
        [Key]
        public int ID { get; set; }
        public string EmployeeCode { get; set; }
        public string FullNames { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string LeaveCodeVip { get; set; }
        public string LineNumber { get; set; }
        public string Total { get; set; }
        public string TotalPeriodDays { get; set; }
        public string LeaveTotalDays { get; set; }
        public string Branch { get; set; }
        public string Department { get; set; }
        public string LineManager { get; set; }
        public string EmpoyeeComments { get; set; }
        public string ManagerComments { get; set; }
    }
}
