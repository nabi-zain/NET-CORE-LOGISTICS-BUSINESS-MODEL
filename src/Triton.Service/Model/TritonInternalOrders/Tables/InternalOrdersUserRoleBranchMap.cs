using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("UserRoleBranchDepartmentMap")]
    public class InternalOrdersUserRoleBranchMap
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

        [DisplayName("Role")]
        [Write(false)]
        [Computed]
        public string RoleName { get; set; }

        [DisplayName("Branch\\ Cost Center")]
        [Write(false)]
        [Computed]
        public string BranchFullName { get; set; }

        [DisplayName("Department")]
        [Write(false)]
        [Computed]
        public string Department { get; set; }

        [DisplayName("User")]
        [Write(false)]
        [Computed]
        public string Name { get; set; }

        public int CreatedByUserID { get; set; }
        [DisplayName("Created By")]
        [Write(false)]
        [Computed]
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
      
        [Write(false)]
        [Computed]
        public List<InternalOrdersUserRoleBranchMap> CurrentUserRoleMaps { get; set; }
   
        //[Write(false)]
        //[Computed]
        //public List<SelectListItem> BranchesList { get; set; }
       
        //[Write(false)]
        //[Computed]
        //public List<SelectListItem> DepartmentsList { get; set; }
   
        //[Write(false)]
        //[Computed]
        //public List<SelectListItem> UsersList { get; set; }
       
        //[Write(false)]
        //[Computed]
        //public List<SelectListItem> RolesList { get; set; }

    }
}
