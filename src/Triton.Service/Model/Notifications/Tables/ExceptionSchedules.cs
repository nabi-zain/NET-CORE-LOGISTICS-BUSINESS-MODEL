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
    [Table("ExceptionSchedules")]
   public class ExceptionSchedules
    {
        [Key]
        public int ExceptionScheduleID { get; set; }
        [DisplayName("Exception")]

        public int ExceptionID { get; set; }
        [DisplayName("Frequency")]
        public int FrquencyID { get; set; }
        [DisplayName("Start Date Time")]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        public DateTime StartDateTime { get; set; }
        [DisplayName("Last Run Date Time")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        public DateTime LastRunDateTime { get; set; }
        [DisplayName("Next Run Date Time")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        public DateTime NextRunDateTime { get; set; }
        public string Active { get; set; }

    }
}
