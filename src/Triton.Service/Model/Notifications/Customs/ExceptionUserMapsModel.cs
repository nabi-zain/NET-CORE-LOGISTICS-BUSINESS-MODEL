using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;

namespace Triton.Model.Notifications.Customs
{
   public class ExceptionUserMapsModel
    {
        public ExceptionUserMaps ExceptionUserMap { get; set; }
        public ExceptionSchedules ExceptionSchedules { get; set; }
        public Exceptions Exceptions { get; set; }
        public Triton.Model.TritonSecurity.Tables.Users Users { get; set; }

    }
}
