using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Tables
{
    [Table("tblUseRoleBranchDepartmentMaps")]
    public class tblUserRoleBranchDepartmentMaps
    {
        [Key]
        public  int UserRoleBranchDepartmentID { get; set; }
     

            [DisplayName("User")]
        public  int UserID { get; set; }
   

        [DisplayName("Role")]
        public  int RoleID { get; set; }
        
      
        [DisplayName("Branch")]

        public  int BranchID { get; set; }

        [DisplayName("Department")]
        public  int DepartmentID { get; set; }

       

        [DisplayName("Role")]
        public  tblRoles Roles { get; set; }
      

        public  tblUsers User { get; set; }
     
        [DisplayName("Branch")]

        public  tblMasterBranches Branch { get; set; }

        public  tblDepartments Department { get; set; }
      
        [DisplayName("Friendly Name")]

        public  string FriendlyName { get; set; }
   
    }
}
