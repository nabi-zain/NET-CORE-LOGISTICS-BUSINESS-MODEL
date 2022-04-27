using System;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class CustomersModels
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public string VatRegistration { get; set; }
        public string TelephoneNumber { get; set; }
        public string CellphoneNumber { get; set; }
        public string CompanyRegistration { get; set; }
        public string Email { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal LoyaltySpend { get; set; }
        public int LoyaltyStatusLCID { get; set; }
        public int AccountStatusTypeLCID { get; set; }
        public int CustomerTypeLCID { get; set; }
        public string PhysicalAddress1 { get; set; }
        public string PhysicalAddress2 { get; set; }
        public string PhysicalSuburb { get; set; }
        public string PhysicalPostalCode { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public string PostalSuburb { get; set; }
        public string PostalCode { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public int? CompanyID { get; set; }
        public string CompanyRegistrationAndName
        {
            get
            {
                var companyRegistration = string.IsNullOrEmpty(CompanyRegistration) ? "N/A" : CompanyRegistration;
                return this.Name + " - " + companyRegistration;
            }
        }

    }
}
