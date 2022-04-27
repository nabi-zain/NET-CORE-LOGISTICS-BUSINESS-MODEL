using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("EmployeeContracts")]

    public class EmployeeContracts
    {
        [Key]
        public int ContractId { get; set; }
        public int ExtCodeID { get; set; }
        public int OrgID { get; set; }
        public string JobProfile { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmployeeFullName { get; set; }
        public string ShiftDefault { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string SaidNumber { get; set; }
        public bool IsContractPost { get; set; }
        public decimal? FixedBasic { get; set; }
        public string ManagerName { get; set; }
        public string ManagerJobTitle { get; set; }
        public int? BranchID { get; set; }
        public string BranchAlias { get; set; }
        public string Company { get; set; }
        public int? ApprovedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public DateTime? ShiftStartTime { get; set; }
        public DateTime? ShiftEndTime { get; set; }
        public string CompanyRegNo { get; set; }
        public string WorkingDays { get; set; }
        public decimal? InclusiveWorkingHours { get; set; }
        public decimal? CellAllowance { get; set; }
        public decimal? CarAllowance { get; set; }
        public string ProfitShareIncentive { get; set; }
    }
}
