using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    public class CustomerAdjustmentNotes
    {
        public int CustomerAdjustmentNoteID { get; set; }
        public int CustomerAdjustmentID { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public int CreatedByID { get; set; }
        public byte IsMail { get; set; }
        public int NotificationID { get; set; }
    }
}
