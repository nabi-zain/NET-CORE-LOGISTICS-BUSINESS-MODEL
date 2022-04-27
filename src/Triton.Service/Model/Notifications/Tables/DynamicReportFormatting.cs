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
    [Table("DynamicReportFormatting")]
  public class DynamicReportFormatting
    {
        [Key]
        [DisplayName("Dynamic Format")]
        public int DynamicFormatID { get; set; }
        [DisplayName("Friendly Name")]
        public string FriendlyName { get; set; }
        [Required]
        public string SSRSFormatExpression { get; set; }

    }
}
