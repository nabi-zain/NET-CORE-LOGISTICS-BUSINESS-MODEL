using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonBlobs.Tables
{
    [Table("Blobs")]
    public class Blobs
    {
        [Key]
        public long BlobID { get; set; }

        public byte[] FileData { get; set; }

        public string FileName { get; set; }

        public string ContentType { get; set; }

        public long Length { get; set; }

        public DateTime? DateUploaded { get; set; }

        public long UserUploadedID { get; set; }


    }
}
