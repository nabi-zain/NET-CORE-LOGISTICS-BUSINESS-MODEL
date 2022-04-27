using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveBalances")]
    public class LeaveBalances
    {
        [Key]
        public int ID { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public DateTime? CuttoffDate { get; set; }
        public string AlBalance { get; set; }
        public string SlBalance { get; set; }
        public string FrBalance { get; set; }
        public int? EmployeeID { get; set; }
        public int? LeaveTypeID { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? SlCycleStartDate { get; set; }
        public DateTime? SlCycleEndDate { get; set; }
    }
}
