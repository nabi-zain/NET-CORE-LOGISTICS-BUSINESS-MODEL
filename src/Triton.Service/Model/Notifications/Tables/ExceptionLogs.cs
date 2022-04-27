using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ExceptionLogs")]
    public class ExceptionLogs
      
    {
        [Key]
        public int ExceptionLogID { get; set; }
        [DisplayName("Exception Schedule")]
        public int ExceptionSchedule { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        public DateTime DateTimeRun { get; set; }
        [Required]
        [DisplayName("Are Exception")]
        public string AreException { get; set; }
        [Required]
        [DisplayName("No Of Exception")]
        public int NoOfException { get; set; }

    }
}
