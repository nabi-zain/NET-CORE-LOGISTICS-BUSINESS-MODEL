using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("PayrollReconDocuments")]
    public class PayrollReconDocuments
    {
        public int PayrollReconDocumentID { get; set; }
        public int RecordID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLength { get; set; }
        public DateTime? DateUploaded { get; set; }
        public int? DocumentCategoryID { get; set; }
    }
}
