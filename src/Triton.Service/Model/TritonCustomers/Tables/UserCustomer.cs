using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonCustomers.Tables
{
    [Table("UserCustomer")]
    public class UserCustomer
    {
        [Key]
        public int UserCustomerID { get; set; }
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
    }
}
