using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("Exceptions")]
   public class Exceptions
    {
        [Key]
        public int ExceptionID { get; set; }
        public string DataBaseName { get; set; }
        public string StoreProcedure { get; set; }
        public int ExecptiontypeID { get; set; }
        public int SystemID { get; set; }
    }
}
