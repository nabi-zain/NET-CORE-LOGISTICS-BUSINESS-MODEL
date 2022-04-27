using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Triton.Model.TritonOps.Tables
{
    [Table("BadCargoImages")]
    public class BadCargoImages
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]

        public int BadCargoImageID { get; set; }
        public byte[] FileData { get; set; }
        public int BadCargoID { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long Length { get; set; }
        public DateTime? TimeUploaded { get; set; }
        public int UserUploadedID { get; set; }
    }
}   
