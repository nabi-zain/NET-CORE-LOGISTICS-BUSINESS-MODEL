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
    [Table("ReportExceptioTypes")]
   public class ReportExceptionTypes
    {
        [Key]
        public int TypeID { get; set; }
        [Required]
        [DisplayName("Report Exception Type")]
        public string ReportExceptionType { get; set; }
        [Required]
        [DisplayName("Exception Type Order")]
        public int ExceptionTypeOrder { get; set; }
    }
}
