using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.Applications.Tables
{
    [Table("tblRoles")]
    public class tblRoles
    {
        [Key]
        public  int RoleID { get; set; }
        

        public  int AppID { get; set; }

        public  string RoleName { get; set; }
 

        public  string Archive_Role { get; set; }
  
        public override string ToString()
        {
            return RoleName;
        }
        


    }
}
