using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;
namespace Triton.Model.Notifications.Customs
{
   public class ReportsModel
    {
        public Reports Reports { get; set; }
        public ReportTypes ReportTypes { get; set; }
        public Triton.Model.TritonSecurity.Tables.Systems Systems { get; set; }



    }
}
