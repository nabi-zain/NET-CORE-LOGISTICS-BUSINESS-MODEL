using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("CancelledLeave")]
    public class CancelledLeave
    {
        [Key]
        public int CancelledLeaveID { get; set; }
        public int LeaveId { get; set; }
        public int? DepartmentID { get; set; }
        public int? BranchID { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? LeaveFromDate { get; set; }
        public DateTime? LeaveToDate { get; set; }
        public string TotalDays { get; set; }
        public string TypeOfLeave { get; set; }
        public string EmployeeComment { get; set; }
        public string BmComment { get; set; }
        public string HrComment { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public int? LeaveStartTimeID { get; set; }
        public int? LeaveEndTimeID { get; set; }
        public DateTime? WorkReturnDate { get; set; }
        public int? WorkReturnTimeID { get; set; }
        public int? DmUserID { get; set; }
        public string DmRole { get; set; }
        public int? HrUserIdD { get; set; }
        public int? CreatorOfLeave { get; set; }
        public bool? IsVipExported { get; set; }
        public DateTime? VipExportedDate { get; set; }
        public int? VipExportedBy { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
