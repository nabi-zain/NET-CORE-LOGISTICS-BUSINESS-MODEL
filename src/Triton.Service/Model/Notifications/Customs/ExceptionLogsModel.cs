using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;
namespace Triton.Model.Notifications.Customs
{
  public  class ExceptionLogsModel
    {
        public ExceptionLogs ExceptionLog { get; set; }
        public ExceptionSchedules ExceptionSchedule { get; set; }

    }
}
