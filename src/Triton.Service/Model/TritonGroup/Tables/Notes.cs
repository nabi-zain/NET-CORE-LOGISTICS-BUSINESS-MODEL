using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("Notes")]
    public class Notes
    {
        [Dapper.Contrib.Extensions.Key]
        public Int64 NoteID { get; set; }

        public Int64 FKRecordID { get; set; }
        public String FKTableName { get; set; }
        public int FKSystemID { get; set; }
        public int NoteTypeLCID { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public Int64 CreatedByID { get; set; }
        public bool isMail { get; set; }
        public int NotificationID { get; set; }
    }
}
