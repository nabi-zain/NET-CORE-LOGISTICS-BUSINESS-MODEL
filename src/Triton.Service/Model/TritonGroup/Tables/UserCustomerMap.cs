using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("UserCustomerMap")]
    public class UserCustomerMap
    {
        [Dapper.Contrib.Extensions.Key]
        public int UserCustomerMapID { get; set; }
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public int SystemID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
