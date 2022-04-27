using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ExceptionUserParameterMaps")]
    public class ExceptionUserParameterMaps
    {
        [Key]
        public int ExceptionUserParameterMapID { get; set; }
        public int ExceptionID { get; set; }
        public int ExceptionParamaeterID { get; set; }
        public string Value {get;set;}

    }
}
