using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("UserNoteType")]
   public class UserNoteType
    {
        [Key]
        public int UserNoteTypeID { get; set; }
        public string Category { get; set; }
        public int SystemID { get; set; }

    }
}
