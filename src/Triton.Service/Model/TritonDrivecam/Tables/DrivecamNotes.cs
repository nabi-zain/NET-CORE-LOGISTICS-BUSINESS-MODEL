using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonDrivecam.Tables
{
    [Table("DrivecamNotes")]
    public class DrivecamNotes
    {
        [Dapper.Contrib.Extensions.Key]

        public long DrivecamNoteID { get; set; }
        public long DrivecamID { get; set; }
        [DisplayName("Note")]
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public int CreatedByID { get; set; }
        public int IsMail { get; set; }
        public long NotificationID { get; set; }
        public int NoteTypeID { get; set; }
    }
}
