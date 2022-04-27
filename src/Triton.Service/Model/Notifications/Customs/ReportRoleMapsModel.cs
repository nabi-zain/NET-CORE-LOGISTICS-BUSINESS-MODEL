using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;
namespace Triton.Model.Notifications.Customs
{
   public class ReportRoleMapsModel
    {
        public ReportRoleMaps ReportRoleMaps { get; set; }
        public Reports Reports { get; set; }
        public Triton.Model.TritonSecurity.Tables.Roles Roles { get; set; }



    }
}
