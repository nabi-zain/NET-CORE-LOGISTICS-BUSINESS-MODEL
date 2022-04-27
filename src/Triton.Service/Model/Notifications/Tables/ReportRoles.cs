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
    [Table("ReportRoles")]
   public class ReportRoles
    {
        [Key]
        public int ReportRoleID { get; set; }
        [DisplayName("Report Schedule")]
        public int ReportScheduleID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]

        public DateTime DateTimeStamp { get; set; }
        [Required]
        public string Succeeded { get; set; }
        [Required]
        public string Exception { get; set; }

    }
}
