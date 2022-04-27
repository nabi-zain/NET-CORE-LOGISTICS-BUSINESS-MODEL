using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("EmployeeDocuments")]
    public class EmployeeDocuments
    {
        [Key]
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public string ImgLength { get; set; }
        public DateTime? DateUploaded { get; set; }
        public int? EmployeeDocumentCategoryId { get; set; }
        public decimal? AppScore { get; set; }
        public int? AppYear { get; set; }
        public int? AppMonthId { get; set; }
    }
}

