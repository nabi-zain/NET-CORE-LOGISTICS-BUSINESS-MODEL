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
    [Table("ReportUserMap")]
   public class ReportUserMaps
    {
        [Key]
        public int ReportUserMapID { get; set; }
        [Required]
        [DisplayName("Report Schedule")]
        public int ReportScheduleID { get; set; }
        public int ReportID { get; set; }
        public int UserID { get; set; }
        [Required]
        [DisplayName("Report Format Type")]
        public string ReportFormatTypeID { get; set; }
        public string Active { get; set; }
        [Required]
        [DisplayName("Frequency")]
        public int FrequencyID { get; set; }
        [Required]
        [DisplayName("Frequency Setting")]
        public string FrequencySetting { get; set; }

    }
}
