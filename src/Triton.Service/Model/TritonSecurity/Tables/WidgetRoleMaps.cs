using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("WidgetRoleMaps")]
  public class WidgetRoleMaps
    {
        [Key]
        public int WidgetRoleMapID { get; set; }
        public int WidgetID { get; set; }
        public int RoleID { get; set; }

    }
}
