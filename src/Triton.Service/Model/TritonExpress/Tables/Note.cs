using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("Notes")]
    public class Note
    {

        [Dapper.Contrib.Extensions.Key]
        public long NoteID { get; set; }
        public long NoteTypeLookupID { get; set; }
        public long RecordID { get; set; }
        public string Notes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        [DisplayName("Created By")]
        [Write(false)]
        [Computed]
        public string Name { get; set; }
    }
}
