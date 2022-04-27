using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblMasterSuppliers")]
    public class tblMasterSuppliers
    {
        [Dapper.Contrib.Extensions.Key]
        
        public int SupplierID { get; set; }

        [DisplayName("Supplier Name")]
        [Required]
        public string SupplierName { get; set; }
        [Required]
        public int? GLCodeID { get; set; }

        [Required]
        [DisplayName("Type")]
        public int? SupplierTypeID { get; set; }

        [Required]
        [DisplayName("Email")]
        public string SupplierEmail { get; set; }

        [DisplayName("Alt. Email")]
        [Required]
        public string SupplierEmail2 { get; set; }

        [DisplayName("Vendor Code")]
        [Required]
        public string VendorID { get; set; }
        [Required]
        public string SupplierShortName { get; set; }

        [Required]
        [DisplayName("Address Line 1")]
        public string SupplierAdd1 { get; set; }
        
        [Required]
        [DisplayName("Address Line 2")]
        public string SupplierAdd2 { get; set; }


        [Required]
        [DisplayName("Address Line 3")]
        public string SupplierAdd3 { get; set; }


        [Required]
        [DisplayName("Address Line 4")]
        public string SupplierAdd4 { get; set; }

        [Required]
        public string SupplierReviewDate { get; set; }

        [Required]
        public string SupplierPhone1 { get; set; }

        [Required]
        public string SupplierPhone2 { get; set; }

        [Required]
        [DisplayName("Terms")]
        public int? SupplierTermID { get; set; }

        [Required]
        [DisplayName("Contact Phone")]
        public string SupplierContactPhone { get; set; }

        [Required]
        [DisplayName("Contact Fax")]
        public string SupplierContactFax { get; set; }

        [Required]
        [DisplayName("Vat No.")]
        public string SupplierVatNo { get; set; }

        [Required]
        [DisplayName("Expense Type")]
        public string SupplierExpenseType { get; set; }

        [Required]
        public int? StatusID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? StatusDate { get; set; }

        [Required]
        [DisplayName("AdminGroup")]
        public int? AdminGroupID { get; set; }

        [Required]
        public string AlternateUse { get; set; }

        [Required]
        public int? CompanyID { get; set; }

        [Required]
        [DisplayName("Vat Vendor")]
        public bool? VATVendor { get; set; }

        [Required]
        public int? CountryID { get; set; }

        [Required]
        public int? SupplierUseCategoryID { get; set; }

        [Required]
        public DateTime? ReviewDate { get; set; }

        [Required]
        public string RepName { get; set; }

        [Required]
        [DisplayName("Limit")]
        public decimal? AccountLimit { get; set; }

        [Required]
        public decimal? EarlySetllementDiscPerc { get; set; }

        [Required]
        public int? TotalRevenue { get; set; }

        [Required]
        public decimal? TotalRevenueAmount { get; set; }

        [Required]
        public int? OwnershipOfCompany { get; set; }

        [Required]
        public int? OwnershipOfCompanyAmount { get; set; }

        [Required]
        public string DirectorName { get; set; }

        [Required]
        public int? PaymentTypeID { get; set; }

        [Required]
        public int? CreditCardType { get; set; }

        [Required]
        [DisplayName("CutOff Day")]
        public int? CutOffDay { get; set; }

        [Required]
        [DisplayName("Reciprocal")]
        public Boolean hasReciprocalBusiness { get; set; }

        [Required]
        [DisplayName("LOGS Expiry")]
        public DateTime? LOGSExpiryDate { get; set; }
        [Required]
        [DisplayName("Insurance")]
        public String InsuranceName { get; set; }

        [Required]
        [DisplayName("GIT Amount")]
        public int GITAmount { get; set; }

        [Required]
        [DisplayName("GIT Expiry")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? GITExpiryDate { get; set; }
    }
}
