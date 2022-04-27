using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("CustomerLogo")]
    public class CustomerLogo
    {
        [Dapper.Contrib.Extensions.Key]
        public int CustomerLogoID { get; set; }
        public int CustomerID { get; set; }
        public byte[] ImgData { get; set; }
        public int SystemID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
