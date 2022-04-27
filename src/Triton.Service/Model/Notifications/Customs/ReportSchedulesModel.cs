using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;
namespace Triton.Model.Notifications.Customs
{
   public class ReportSchedulesModel
    {
        public ReportSchedules ReportSchedules { get; set; }
        public Reports Reports { get; set; }
        public Frequencys Frequencys { get; set; }
    }
}
