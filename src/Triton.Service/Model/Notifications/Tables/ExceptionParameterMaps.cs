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
    [Table("ExceptionParameterMaps")]
    public class ExceptionParameterMaps
    {
        [Key]
       public int ExceptionParameterMapID{get;set;}
        [DisplayName("Exception")]
        public int ExceptionID { get; set; }
        [DisplayName("Parametername")]
        public string ParameterName { get; set; }
        [DisplayName("ParameterType")]
        public string parameterType { get; set; }
        [DisplayName("Parameter Order")]
        public int ParameterOrder { get; set; }

    }
}
