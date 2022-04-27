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
    [Table("ReportExceptionUserParameterMaps")]
   public class ReportExceptionUserParameterMaps
    {
        [Key]
        public int ReportExceptionUserParameterMapID { get; set; }
        [Required]
        [DisplayName("Report Exception")]
        public int ReportExceptionID { get; set; }
        [DisplayName("user")]
        [Required]
        public int UserID { get; set; }
        [Required]
        public string Active { get; set; }

    }
}
