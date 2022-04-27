using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonDrivecam.Tables
{
    [Table("DrivecamDocuments")]
    public class DrivecamDocuments
    {
        [Dapper.Contrib.Extensions.Key]

        public long DrivecamDocumentID { get; set; }
        public long DrivecamID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLength { get; set; }
        public DateTime? DateUploaded { get; set; }
        public int DrivecamDocumentCategoryID { get; set; }


    }
}
