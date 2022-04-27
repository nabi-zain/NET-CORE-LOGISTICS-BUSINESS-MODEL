using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("Leave")]
    public class Leave
    {
        public int LeaveID { get; set; }
        public int? DepartmentID { get; set; }
        public int? BranchID { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? LeaveFromDate { get; set; }
        public DateTime? LeaveToDate { get; set; }
        public  string TotalDays { get; set; }
        public string TypeOfLeave { get; set; }
        public string EmployeeComment { get; set; }
        public string BmComment { get; set; }
        public string HrComment { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public int? LeaveStartTimeId { get; set; }
        public int? LeaveEndTimeId { get; set; }
        public DateTime? WorkReturnDate { get; set; }
        public int? WorkReturnTimeID { get; set; }
        public int? DmUserID { get; set; }
        public string DmRole { get; set; }
        public int? HrUserID { get; set; }
        public int? CreatorOfLeave { get; set; }
        public bool? IsVipExported { get; set; }
        public DateTime? VipExportedDate { get; set; }
        public int? VipExportedBy { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
