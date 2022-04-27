using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
    [Table("DocumentRepository")]
    public class DocumentRepositoryModel
    {
        [Dapper.Contrib.Extensions.Key]
        public Int64 DocumentRepositoryID { get; set; }
        public Int64 RecordID { get; set; }
        public int DocumentTypeLCID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLength { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserID { get; set; }

    }
}
