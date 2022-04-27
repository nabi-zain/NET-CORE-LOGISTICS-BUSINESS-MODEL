using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerDocuments")]
    public class CustomerDocuments
    {
        [Key]
        public int DocumentID { get; set; }
        public int CustomerID { get; set; }
        public string ImgName { get; set; }
        public string ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLenght { get; set; }
        public DateTime dateUpLoaded { get; set; }
        public int DocumentCategoryID { get; set; }
    }
}
