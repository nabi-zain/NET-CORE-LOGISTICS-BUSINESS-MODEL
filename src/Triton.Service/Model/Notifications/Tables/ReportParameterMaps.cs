using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ReportParaeterMaps")]
   public class ReportParameterMaps
    {
        [Key]
        public int ReportParameterMapID { get; set; }
        public int ReportID { get; set; }
        public string Parametername { get; set; }
        public string ParameterType { get; set; }
        public int ParameterOrder { get; set; }
    }
}
