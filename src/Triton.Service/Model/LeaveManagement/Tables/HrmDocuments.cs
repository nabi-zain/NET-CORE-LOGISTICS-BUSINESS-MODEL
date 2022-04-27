using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("HrmDocuments")]
    public class HrmDocuments
    {
        [Key]
        public int HrmDocID { get; set; }
        public long UserID { get; set; }
        public string HrmDisplayName { get; set; }
        public string HrmContentType { get; set; }
        public string HrmLength { get; set; }
        public byte[] HrmDocument { get; set; }
        public short HrmDisplayOrder { get; set; }
        public bool HrmActive { get; set; }
        public DateTime HrmTimeDateStamp { get; set; }
    }
}
