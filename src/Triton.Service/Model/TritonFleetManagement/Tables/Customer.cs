using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("Account Name")]
        [MaxLength(255)]
        public string Name { get; set; }

      
        [Required]
        [DisplayName("Vat Registration")]
        [MaxLength(50)]
        public string VatRegistration { get; set; }


        [Required]
        [DisplayName("Credit Limit")]
        public decimal CreditLimit { get; set; }

        [Required]
        public decimal LoyaltySpend { get; set; }

        [Required]
        public int LoyaltyStatusLCID { get; set; }

        [Required]
        public int AccountStatusTypeLCID { get; set; }

        [Required]
        public int CustomerTypeLCID { get; set; }

        [MaxLength(500)]
        public string PhysicalAddress1 { get; set; }

        [MaxLength(500)]
        public string PhysicalAddress2 { get; set; }

        [MaxLength(500)]
        public string PhysicalSuburb { get; set; }

        [MaxLength(10)]
        public string PhysicalPostalCode { get; set; }

        [MaxLength(500)]
        public string PostalAddress1 { get; set; }

        [MaxLength(500)]
        public string PostalAddress2 { get; set; }

        [MaxLength(500)]
        public string PostalSuburb { get; set; }

        [MaxLength(500)]
        public string PostalCode { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public int CreatedByUserID { get; set; }

        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }

        public int ? CompanyID { get; set; }
        public string CompanyRegistration { get; set; }
    }
}
