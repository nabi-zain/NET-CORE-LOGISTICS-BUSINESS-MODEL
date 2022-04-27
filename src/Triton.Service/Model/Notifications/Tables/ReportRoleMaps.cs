using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ReportRoleMaps")]
   public class ReportRoleMaps
    {
        [Key]
        public int ReportRoleMapID { get; set; }
        public int ReportID { get; set; }
        public int RoleID { get; set; }

    }
}
