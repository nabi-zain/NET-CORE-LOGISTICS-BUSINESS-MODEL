using System;
using Dapper.Contrib.Extensions;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Triton.Model.CRM.Tables
{
    [Table("AdjustmentDocuments")]
    public class AdjustmentDocuments
    {
        [Key]
        public int AdjustmentDocumentID { get; set; }
        public int AdjustmentID { get; set; }
        public string ImgName { get; set; }
        public string ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLength { get; set; }
        public DateTime DateUploaded { get; set; }
        public int DocumentCategoryID { get; set; }
    }
}
