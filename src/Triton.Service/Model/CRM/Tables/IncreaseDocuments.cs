using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("IncreaseDocuments")]
    public class IncreaseDocuments
    {
        [Key]
        public int DocumentID { get; set; }
        public int AnalysisID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public decimal ImgLength { get; set; }
        public DateTime DateUploaded { get; set; }
        public int DocumentCategoryID { get; set; }
        public int EdocsDocID { get; set; }
        public int EdocsEnvelopeID { get; set; }
    }
}
