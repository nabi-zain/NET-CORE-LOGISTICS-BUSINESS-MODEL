using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("Uploader")]
    public class Uploader
    {
        [Dapper.Contrib.Extensions.Key]
        public int UploadID { get; set; }
        public byte[] FileData { get; set; }
        public int? EmployeeID { get; set; }
        public int? LeaveID { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long? Length { get; set; }
        public DateTime? TimeUploaded { get; set; }
        public int? UserUploadedID { get; set; }
        public int? NumPages { get; set; }
        public byte[] Thumbnail { get; set; }
    }
}
