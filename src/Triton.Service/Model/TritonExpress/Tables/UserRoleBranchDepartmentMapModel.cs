using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("UserRoleBranchDepartmentMap")]
    public class UserRoleBranchDepartmentMapModel
    {

        [Dapper.Contrib.Extensions.Key]
        public long UserrolebranchdepartmentID { get; set; }

        public int RoleID { get; set; }
        
        public long UserID { get; set; }
        
        public int BranchID { get; set; }

        public int DepartmentID { get; set; }

        [DisplayName("Signatory Title")]
        //[Write(false)]
        //[Computed]
        public string Signatorytitle { get; set; }
     
        [DisplayName("Role Name")]
        [Write(false)]
        [Computed]
        public string RoleName { get; set; }

        [DisplayName("Branch Name")]
        [Write(false)]
        [Computed]
        public string BranchFullName { get; set; }

        [DisplayName("Department Name")]
        [Write(false)]
        [Computed]
        public string Department { get; set; }

        [DisplayName("Full Name")]
        [Write(false)]
        [Computed]
        public string Name { get; set; }

        public int CreatedByUserID { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}
