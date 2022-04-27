using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("DocumentRepositories")]
    public class DocumentRepositories
    {
        [Key]
        public long DocumentRepositoryID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public int ImgLength { get; set; }
        public int? LookupcodeID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
    }
}
