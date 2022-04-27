using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ExceptionTypes")]
  public  class ExceptionTypes
    {
        public int ExceptionTypeID { get; set; }
        public string Description { get; set; }
    }
}
