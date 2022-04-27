using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("SaStaffAdvanceEntrys")]
    public class SaStaffAdvanceEntrys
    {
        [Key]
        public int SaStaffAdvanceEntryID { get; set; }
     
        public string Com { get; set; }
        public string Form { get; set; }
        public string EmployeeCode { get; set; }
        public string RawCategory { get; set; }
        public DateTime Period { get; set; }
        public DateTime DateofTx { get; set; }
        public string Reason { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal? Additional { get; set; }
        public decimal? VipRepayment { get; set; }
        public decimal? Journal { get; set; }
        public decimal ClosingBalance { get; set; }
        public DateTime MonthYear { get; set; }
    }
}
