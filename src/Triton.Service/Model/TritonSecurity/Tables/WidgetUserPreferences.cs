using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("WidgetUserPreferences")]
   public class WidgetUserPreferences
    {
        public int WidgetUserPreferenceID { get; set; }
        public int WidgetID { get; set; }
        public string UserName { get; set; }
        public string Preference { get; set; }

    }
}
