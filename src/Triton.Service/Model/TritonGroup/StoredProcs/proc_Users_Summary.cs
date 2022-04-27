using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonGroup.StoredProcs
{
    public class proc_Users_Summary
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public int? AppVersion { get; set; }
        public string sAMAccountName { get; set; }
        public string FWUsername { get; set; }
        public int? OldUserID { get; set; }
        public int EmployeeID { get; set; }
        public int CostCentreID { get; set; }
        public string RoleIds { get; set; }
        public string Branches { get; set; }
        public string BranchName { get; set; }
        public string RoleNames { get; set; }
        public string JobProfile { get; set; }
        public string Email { get; set; }
        public string Employee { get; set; }
    }
}
