using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("PayrollReconNotes")]
    public class PayrollReconNotes
    {
        [Key]
        public int PayrollReconNoteID { get; set; }
       public string Comment { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int? CreatedByID { get; set; }
        public bool? IsMail { get; set; }
        public int? NotificationID { get; set; }
        public int? NoteTypeID { get; set; }
    }
}
