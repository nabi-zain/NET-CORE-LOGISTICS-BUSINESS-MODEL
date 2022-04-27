using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;
namespace Triton.Model.Notifications.Customs
{
   public class ReportUserMapsModel
    {
        public ReportUserMaps ReportUserMaps { get; set; }
        public Reports Reports { get; set; }
        public ReportSchedules ReportSchedules { get; set; }
        public Triton.Model.TritonSecurity.Tables.Frequency Frequencys { get; set; }
        public Triton.Model.TritonSecurity.Tables.Users Users { get; set; }
    }
}
