using Dapper.Contrib.Extensions;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Users")]
    public class Users : IdentityUser
    {
        [ScaffoldColumn(false)]
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public Int64 UserID { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "{0} must be a characters.")]
        public string sAMAccountName { get; set; }

        //public string Name { get; set; }

        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; } 

        public bool Active { get; set; }

        [DisplayName("First Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "{0} must be a characters.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "{0} must be a characters.")]
        public string LastName { get; set; }

        public string BBPin { get; set; }

        public string FWUsername { get; set; }

        //[Required]
        //public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        //Additional Properties
        [ScaffoldColumn(false)]
        [Write(false)]
        public int? EmployeeID { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        public int? BranchID { get; set; }
        //Additional Properties
        [ScaffoldColumn(false)]
        [Write(false)]
        public int? CostCentreID { get; set; }
        [ScaffoldColumn(false)]
        [Write(false)]
        public int? DepartmentID { get; set; }
        //[ScaffoldColumn(false)]
        //[Write(false)]
        //public string Id
        //{
        //    get { return UserID.ToString(); }
        //}

        [ScaffoldColumn(false)]
        [Write(false)]
        public string Roles { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        public string Branches { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        public string BranchFullName { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        public string BranchName { get; set; }

        [ScaffoldColumn(false)]
        [Write(false)]
        public string RoleNames { get; set; }
    }
}