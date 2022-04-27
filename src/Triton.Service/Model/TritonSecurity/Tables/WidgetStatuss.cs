using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("WidgetStatuss")]
   public class WidgetStatuss
    {
        [Key]
        public int WidgetStatusID { get; set; }
        public string WidgetStatus { get; set; }
    }
}
