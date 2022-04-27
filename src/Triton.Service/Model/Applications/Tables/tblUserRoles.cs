using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using Triton.Model.Applications.Custom;

namespace Triton.Model.Applications.Tables
{
    [Table("tblUserRoles")]
     public class tblUserRoles
    {
        [Key]
        public  int UserRoleID { get; set; }
     
        [DisplayName("UserID")]
        public  int UserID { get; set; }
  

        public  int RoleID { get; set; }
   

        public  tblRoles Roles { get; set; }


        public  tblUsers User { get; set; }
      
        public  string Archive_UserRole { get; set; }
    



    }
}

