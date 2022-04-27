using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.Tables
{
    [Table("WaybillOpsNotes")]
    public class WaybillOpsNotes
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]
        public int WaybillOpsNoteID { get; set; }

        public long WaybillID { get; set; }

        public string WaybillNo { get; set; }

        public string Comment { get; set; }

        public DateTime? TimeStamp { get; set; }

        public long? CreatedByID { get; set; }

        public bool? IsMail { get; set; }

        public int? NotificationID { get; set; }

        public int? NoteTypeID { get; set; }

        public int? FWEventCodeID { get; set; }

        public string FWEventLocation { get; set; }

        public string FWEventUser { get; set; }

        public string FWNoteRef { get; set; }

        public bool? CustomerNote { get; set; }

        
    }
}