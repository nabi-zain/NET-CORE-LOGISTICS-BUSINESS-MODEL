using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;
namespace Triton.Model.Notifications.Customs
{
  public  class ExceptionScheduleResultsModel
    {
        public ExceptionScheduleResults ExceptionScheduleResult { get; set; }
        public ExceptionLogs ExceptionLog { get; set; }
        public Exceptions Exception { get; set; }
        public ExceptionSchedules ExceptionSchedules { get; set; }
    }
}
