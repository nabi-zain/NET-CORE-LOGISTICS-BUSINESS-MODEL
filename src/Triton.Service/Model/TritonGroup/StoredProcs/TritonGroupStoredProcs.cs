using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Triton.Model.Applications.Tables;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonGroup.Tables;
using Customers = Triton.Model.CRM.Tables.Customers;
using Roles = Triton.Model.TritonGroup.Tables.Roles;

namespace Triton.Model.TritonGroup.StoredProcs
{
    public class proc_Users_UserCustomerMap_Insert
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int? CreatedByUserID { get; set; }
        public int? EmployeeID { get; set; }
        public int? AppVersion { get; set; }
        public int? SystemID { get; set; }
        public int? CustomerID { get; set; }
        public int? SupplierID { get; set; }
    }

    public class UserDetails
    {
        public Users Users { get; set; }
        public List<Customers> Customers { get; set; }
        public Employees Employees { get; set; }
        public List<tblMasterSuppliers> Suppliers { get; set; }
        public List<UserRoles> UserRoles { get; set; }
        public List<Roles> Roles { get; set; }
        public List<UserMap> UserMap { get; set; }
    }

    public class UserInformation
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
        public string SystemUrl { get; set; }
    }
}
