using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("BlikDocuments")]
    public class BlikDocuments
    {
        [Key]
        public int BlikId { get; set; }
        public byte[] FileData { get; set; }
        public int? SalaryEmpMapId { get; set; }
        public int? LeaveId { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long? Length { get; set; }
        public DateTime? TimeUploaded { get; set; }
        public int? UserUploadedId { get; set; }
        public int? NumPages { get; set; }
    }
}
