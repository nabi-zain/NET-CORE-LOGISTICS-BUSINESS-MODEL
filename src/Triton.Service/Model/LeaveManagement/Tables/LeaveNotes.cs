using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveNotes")]
    public class LeaveNotes
    {
        [Key]
        public int LeaveNoteID { get; set; }
        public string Comment { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? RecordID { get; set; }
        public bool? IsMail { get; set; }
        public int? NotificationID { get; set; }
    }
}
