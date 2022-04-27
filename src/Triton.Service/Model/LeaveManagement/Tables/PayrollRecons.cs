using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("PayrollRecons")]
    public class PayrollRecons
    {
        [Key]
        public int PayrollReconID { get; set; }
        public int PayrollMonth { get; set; }
        public int PayrollYear { get; set; }
        public int CostCenterID { get; set; }
        public int DepartmentID { get; set; }
        public DateTime DateInitiated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public int PayrollReconStatusID { get; set; }
    }
}
