using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    public class LeadNotes
    {
        public int LeadNoteID { get; set; }
        public int LeadID { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public int CreatedByID { get; set; }
        public int IsMail { get; set; }
        public int NotificationID { get; set; }
    }
}
