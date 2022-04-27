using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ReportSchedules")]
   public class ReportSchedules
    {
        [Key]
        public int ReportScheduleID { get; set; }
        public int ReportID { get; set; }
        public int FrequencyID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        [Required]
         public DateTime StartDateTime { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime LastRunDateTime { get; set; }
        public string Active { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)] 
        [Required]
        public DateTime NextRunDateTime { get; set; }
        public string TestForResults { get; set; }
    }
}
