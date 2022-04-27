using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LmReport")]
    public class LmReport
    {
        public string Employeecode { get; set; }
        public string FullName { get; set; }
        public string Leavefromdate { get; set; }
        public string Leavetodate { get; set; }
        public string LeaveTypeDescription { get; set; }
        public string LeaveCode { get; set; }
        public string LeaveCodeVip { get; set; }
        public int? LineNumber { get; set; }
        public decimal? Total { get; set; }
        public string Branch { get; set; }
        public string Department { get; set; }
        public string LineManager { get; set; }
        public string Month { get; set; }
        public int? LineManagerID { get; set; }
    }
}
