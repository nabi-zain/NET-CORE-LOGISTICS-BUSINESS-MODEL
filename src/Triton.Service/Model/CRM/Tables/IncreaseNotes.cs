using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    public class IncreaseNotes
    {
        public int IncreaseNoteID { get; set; }
        public int Analysis { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public int CreatedByID { get; set; }
        public int IsMail { get; set; }
        public int NotificationID { get; set; }
    }
}
