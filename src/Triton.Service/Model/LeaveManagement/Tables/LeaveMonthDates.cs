using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveMonthDates")]
    public class LeaveMonthDates
    {
        [Key]
        public  int LeaveMonthDateId { get; set; }
        public string Month { get; set; }
        public int? CuttofDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public  int? MonthId { get; set; }
        public string Yearlmd { get; set; }
        public string TotalDays { get; set; }
    }
}
