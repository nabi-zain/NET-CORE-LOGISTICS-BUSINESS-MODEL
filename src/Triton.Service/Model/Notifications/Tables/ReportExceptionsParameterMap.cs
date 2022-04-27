using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ReportExceptionsParameterMap")]
  public  class ReportExceptionsParameterMap
    {
        public int ReportExceptionsParameterID { get; set; }
        public int ReportException { get; set; }
        public string ParameterName { get; set; }
        public string ParameterType { get; set; }
        public int ParameterOrder { get; set; }

    }
}
