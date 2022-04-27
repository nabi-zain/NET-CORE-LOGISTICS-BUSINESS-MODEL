using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("Notes")]
    public class OrderNotes
    {
        [Dapper.Contrib.Extensions.Key]
       public long OrderNoteID { get; set; }
        public long OrderID { get; set; }
        public string Notes { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        [DisplayName("Created By")]
        [Write(false)]
        [Computed]
        public string Name { get; set; }
    }
}
