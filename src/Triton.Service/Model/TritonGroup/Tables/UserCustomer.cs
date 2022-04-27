using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("UserCustomer")]
    public class UserCustomer
    {
        [Dapper.Contrib.Extensions.Key] public int UserCustomerID { get; set; }
        [Required] public int UserID { get; set; }
        [Required] public int CustomerID { get; set; }
        [Required] public DateTime CreatedOn { get; set; } = DateTime.Now;
        [Required] public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
    }
}
