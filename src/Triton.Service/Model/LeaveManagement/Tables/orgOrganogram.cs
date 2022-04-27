using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("orgOrganogram")]
    public class orgOrganogram
    {
        [Dapper.Contrib.Extensions.Key]
        public int orgID { get; set; }

        public long UserID { get; set; }
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
    }
}
