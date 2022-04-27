using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveAdjustmentDocuments")]
    public class LeaveAdjustmentDocuments
    {
        [Key]
        public int ID { get; set; }
        public int? RecordID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLength { get; set; }
        public DateTime? DateUploaded { get; set; }
    }
}
