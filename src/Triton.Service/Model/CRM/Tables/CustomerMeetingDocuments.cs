using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerMeetingDocuments")]
    public class CustomerMeetingDocuments
    {
        public int DocumentID { get; set; }
        public int CustomerMeetingID { get; set; }
        public string ImgName { get; set; }
        public string ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLength { get; set; }
        public DateTime DateUploaded { get; set; }
        public int DocumentCategoryID { get; set; }
    }
}
