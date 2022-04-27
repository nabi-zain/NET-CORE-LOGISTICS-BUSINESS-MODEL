using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("Rolesoldold")]
    public class Rolesoldold
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
