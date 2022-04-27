using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.LeaveManagement.StoredProcs
{
    public class proc_orgOrganogram_ByBranchID_JobProfileID_Select
    {
        [Dapper.Contrib.Extensions.Key]
        public int orgID { get; set; }

        [ScaffoldColumn(false)]
        public long UserID { get; set; }

        [ScaffoldColumn(false)]
        public int ptID { get; set; }
        
        public int orgJobTitle { get; set; }
        public int? orgManager { get; set; }
        public int? orgDottedManager { get; set; }
        public int? EmployeeID { get; set; }
        public string orgEmail { get; set; }
        public bool orgActive { get; set; }
        public DateTime orgTimeDateStamp { get; set; }
        public short? DepotID { get; set; }
        public int? CostCentreID { get; set; }
        public int? DepartmentID { get; set; }
        public int? GroupID { get; set; }
        public short? ocoID { get; set; }
        public DateTime orgEffectiveDate { get; set; }
        public DateTime? orgDecommissioned { get; set; }
        public bool? orgConfidential { get; set; }
        public int? CompanyID { get; set; }
        public int ocaCellAllowanceID { get; set; }
        public int? orgVehicleID { get; set; }

        [DisplayName("Employee Code")]
        public string CurrentEmployeeCode { get; set; }

        [DisplayName("Name")]
        public string DisplayName { get; set; }

        [DisplayName("Job Profile")]
        public string JobProfileDescription { get; set; }

        [ScaffoldColumn(false)]
        public int ActualUserID { get; set; }
    }
}
