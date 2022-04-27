using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("FormatTypes")]
   public class FormatTypes
    {
        [Key]
        public int FormatTypeID { get; set; }
        public string Description { get; set; }
        public string FilrExtention { get; set; }

    }
}
