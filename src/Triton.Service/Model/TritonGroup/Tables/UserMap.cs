using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("UserMap")]
    public class UserMap
    {
        [Dapper.Contrib.Extensions.Key]
        public int UserMapID { get; set; }

        [Required]
        public int UserID { get; set; }

        public int? EmployeeID { get; set; }

        public int? CustomerID { get; set; }

        public int? SupplierID { get; set; }

        [Required]
        public int UserTypeLCID { get; set; }

        [Required]
        public int SystemID { get; set; }

        [Required]
        public int CreatedByUserID { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public int? DeletedByUserID { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
