using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerSwatReviewDocuments")]
    public class CustomerSwatReviewDocuments
    {
        [Key]
        public int CustomerSwatReviewDocumentID { get; set; }
        public int CustomerSwatReviewID { get; set; }
        public string ImgName { get; set; }
        public string ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLength { get; set; }
        public DateTime DateUpLoaded { get; set; }
    }
}
