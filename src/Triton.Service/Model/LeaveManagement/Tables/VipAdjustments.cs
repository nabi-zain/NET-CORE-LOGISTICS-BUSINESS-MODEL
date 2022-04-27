using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("{VipAdjustments")]
    public class VipAdjustments
    {
        [Key]
        public int ID { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? LeaveFromDate { get; set; }
        public DateTime? LeaveToDate { get; set; }
        public string LeaveType { get; set; }
        public decimal? LeaveTaken { get; set; }
    }
}
