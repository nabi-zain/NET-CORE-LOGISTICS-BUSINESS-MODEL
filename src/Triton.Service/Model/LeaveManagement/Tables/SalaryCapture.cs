using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("SalaryCapture")]
    public class SalaryCapture
    {
        [Key]
        public int ID { get; set; }
        public string Year { get; set; }
        public int? Month { get; set; }
        public int? UserID { get; set; }
        public int? BlikID { get; set; }
        public string TotalDaysAl { get; set; }
        public string TotalDaysSl { get; set; }
        public int? BranchID { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string IsComplete { get; set; }
    }
}
