using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("Employees")]
    public class Employees
    {
        [Dapper.Contrib.Extensions.Key]
        public int EmployeeID { get; set; }
        public string CurrentEmployeeCode { get; set; }
        public string Initials { get; set; }
        [DisplayName("Employee")]
        public string FullNames { get; set; }
        public string Surname { get; set; }
        public string SAID { get; set; }
        public DateTime? DateOFBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Title { get; set; }
        public int? CurrentDepartmentID { get; set; }
        public int? CurrentPaypointID { get; set; }
        public string CurrentAvlAnnLeave { get; set; }
        public string CurrentAvlSickLeave { get; set; }
        public string CurrentAvlFamRespLeave { get; set; }
        public string ALDays { get; set; }
        public DateTime? AnnLveCycleEndDate { get; set; }
        public DateTime? LveCycleEnd { get; set; }
        public string StartTimes { get; set; }
        public string EndTimes { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public int? UserID { get; set; }
        public int? LineManagerID { get; set; }
        public int? BranchAdminID { get; set; }
        public int? BranchID { get; set; }
        public int? DepartmentID { get; set; }
        public int? GroupID { get; set; }
        public string EmployeeType { get; set; }
        public string IsExec { get; set; }
        [DisplayName("Name")]
        [Write(false)]
        public string DisplayName { get; set; }
        public string Fulln { get; set; }
        public string Sur { get; set; }
        public string EmployeeStatus { get; set; }
        public bool? isAutoCalculate { get; set; }
        public string NotificationInterval { get; set; }
        public string EmployeeStatusTest { get; set; }
        [Write(false)]
        public string LeaveDisplayName { get; set; }
        public string Alias { get; set; }
        public string PaypointCode { get; set; }
        public DateTime? ImportDate { get; set; }
        public bool? hasNoLicenses { get; set; }
        public bool IsPermenent { get; set; }
        public int ContractTerms { get; set; }
        public string TaxNumber { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string LeaveMonth { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        public int CostCentreID { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        public int? ActualUserID { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        public int UploadID { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        public string JobProfileDescription { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        [Computed]
        public string DropDownName
        {
            get { return CurrentEmployeeCode + " - " + DisplayName; }

        }
    }
}
