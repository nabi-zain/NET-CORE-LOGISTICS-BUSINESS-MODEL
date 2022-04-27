using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ReportLogs")]
   public class ReportLogs
    {
        [Key]
        public int ReportLogID { get; set; }
        public int ReportScheduleID { get; set; }
        public DateTime DateTimeSent { get; set; }
        public int Succeeded { get; set; }
        public string Exception { get; set; }

    }
}
