using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.Custom
{
    public class BranchUserDepartmentsRolesModel
    {
        public int UserID { get; set; }
        public string EmailAddress { get; set; }

        public bool Active { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Roles { get; set; }

        public string Branches { get; set; }
        public string BranchFullName { get; set; }
        public string BranchName { get; set; }
        public string RoleNames { get; set; }

        public string Department { get; set; }

        public int TotalUsers { get; set; }
        public int ActiveUsers { get; set; }
        public int InactiveUsers { get; set; }
    }
}
