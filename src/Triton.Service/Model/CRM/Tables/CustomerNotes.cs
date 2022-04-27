using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerNotes")]
    public class CustomerNotes
    {
        [Key]
        public int CustomerNoteID { get; set; }
        public int CustomerID { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public int CreatedByUserID { get; set; }
        public byte IsMail { get; set; }
        public int NotificationID { get; set; }
        public int NoteTypeID { get; set; }
        public int FWEventCodeID { get; set; }
        public string FWEventLocation { get; set; }
        public string FWEventUser { get; set; }
        public string FWNoteRef { get; set; }
        public string CustomerCode { get; set; }
    }
}
