using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;

namespace Triton.Model.Notifications.Customs
{
   public class ExceptionSchedulesModel
    {
        public ExceptionSchedules ExceptionSchedule { get; set; }
        public Exceptions Exception { get; set; }
        public Frequencys Frequencys { get; set; }
    }
}
