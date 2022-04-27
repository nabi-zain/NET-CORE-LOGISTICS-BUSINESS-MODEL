using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("orgUserRoleBranchDepartmentMap")]
    public class orgUserRoleBranchDepartmentMap
    {
        [Key]
        public int UserRoleBranchDepartmentID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int BranchID { get; set; }
        public int DepartmentID { get; set; }
        public int LineManagerID { get; set; }
        public int SignatoryTitle { get; set; }
    }
}
