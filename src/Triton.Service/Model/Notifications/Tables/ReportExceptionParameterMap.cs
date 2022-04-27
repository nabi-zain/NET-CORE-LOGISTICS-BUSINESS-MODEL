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
    [Table("ReportExceptionParameterMap")]
   public class ReportExceptionParameterMap
    {
        [Key]
        public int ReportExceptionParametersID { get; set; }
        [DisplayName("Report Exception")]
        [Required]
        public int ReportExceptionID { get; set; }
        [DisplayName("Parameter Name")]
        [Required]
        public string Parametername { get; set; }
        [DisplayName("Parameter Type")]
        [Required]
        public string ParameterType { get; set; }
        [DisplayName("Parameter Order")]
        public int ParameterOrder { get; set; }

     
    }
}
