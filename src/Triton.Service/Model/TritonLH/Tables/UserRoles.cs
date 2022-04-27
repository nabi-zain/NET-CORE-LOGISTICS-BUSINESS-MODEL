using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.Tables
{
    [Table("UserRoles")]
    public class UserRoles
    {
        [Key]
        public int UserRoleID { get; set; }

        public int UserID { get; set; }

        //public string Name { get; set; }

        public int RoleID { get; set; }
    }
}