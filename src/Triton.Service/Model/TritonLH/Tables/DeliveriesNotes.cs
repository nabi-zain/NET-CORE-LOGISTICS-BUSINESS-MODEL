using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesNotes")]
    public class DeliveriesNotes
    {
        [Dapper.Contrib.Extensions.Key]
        public long DeliveryNoteID { get; set; }

        public long DeliveryID { get; set; }
        public string Note { get; set; }
        public int NoteTypeLCID { get; set; }

        [Required, DisplayName("Created By")]
        public int CreatedByUserID { get; set; }

        [Required, DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }
    }
}
