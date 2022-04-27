using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("DashboardRoleWidgetMaps")]
   public class DashboardRoleWidgetMap
    {
       public int rwmID { get; set; }
        public int roleID { get; set; }
        public int Widget { get; set; }

    }
}
