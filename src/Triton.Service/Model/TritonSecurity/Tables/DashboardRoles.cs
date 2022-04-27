using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("DashBoardRoles")]
  public  class DashboardRoles
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

    }
}
