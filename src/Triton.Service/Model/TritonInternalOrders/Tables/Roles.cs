using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("Roles")]
    public class Roles
    {
        [Dapper.Contrib.Extensions.Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
