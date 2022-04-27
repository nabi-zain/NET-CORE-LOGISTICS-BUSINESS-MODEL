using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveAdjustments")]
    public class LeaveAdjustments
    {
        public int ID { get; set; }
        public DateTime? LeaveDate { get; set; }
        public DateTime? LeaveToDate { get; set; }
        public int? LeaveStartTimeID { get; set; }
        public int? LeaveEndTimeID { get; set; }
        public int? Type { get; set; }
        public decimal? TotalDays { get; set; }
        public int? MonthID { get; set; }
        public int? YearID { get; set; }
        public int? ToType { get; set; }
        public int? LeaveID{ get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string Flag { get; set; }
        public string Creatorof { get; set; }
        public string IsComplete { get; set; }
        public  string Comment { get; set; }
    }
}
