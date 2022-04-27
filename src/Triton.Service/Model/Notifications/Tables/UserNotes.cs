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
    [Table("UserNotes")]
   public class UserNotes
    {
        [Key]
        public int UserNoteID { get; set; }
        [DisplayName("User Note Type")]
        public int UserNoteTypeID { get; set; }

        public int ReferenceID { get; set; }
        [Required]
        public string Note { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime Created { get; set; }
        public int CreatedOn { get; set; }
        [Required]
        public int LookUpCodeID { get; set; }
    }
}
