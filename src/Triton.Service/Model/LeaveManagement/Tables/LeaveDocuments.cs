using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveDocuments")]
    public class LeaveDocuments
    {
        public int LeaveDocumentID { get; set; }
        public int RecordID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLength { get; set; }
        public DateTime? DateUploaded { get; set; }
        public int? DocumentCategoryID { get; set; }
    }
}
