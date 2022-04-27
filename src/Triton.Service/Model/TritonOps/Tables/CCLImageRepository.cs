using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CCLImageRepository")]
    public class CCLImageRepository
    {
        [Dapper.Contrib.Extensions.Key]
        public long CCLImageRepositoryID { get; set; }
        public string ImgName { get; set; }
        public byte[] ImgData { get; set; }
        public string ImgContentType { get; set; }
        public long ImgLength { get; set; }
        public long? CCLID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserID { get; set; }
        public long? CategoryLookUpCodeID { get; set; }
    }
}
