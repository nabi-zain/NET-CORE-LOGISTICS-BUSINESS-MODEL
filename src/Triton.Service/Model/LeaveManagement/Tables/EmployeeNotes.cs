using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("EmployeeNotes")]
    public class EmployeeNotes
    {
        public  int EmployeeNoteID { get; set; }
        public Employees Employees { get; set; }
        public string Comment { get; set; }
        public DateTime? TimeStamp { get; set; }
        public int? CreatedById { get; set; }
        public bool? IsMail { get; set; }
        public int? NotificationID { get; set; }
        public int? NoteTypeID { get; set; }
    }
}
