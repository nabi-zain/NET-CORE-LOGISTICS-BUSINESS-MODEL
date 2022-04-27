using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Views
{
    public class vw_Deliveries
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public Int64 DeliveryID { get; set; }

        [DisplayName("Delivery Note No")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string DeliveryNoteNo { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required, DisplayName("Customer Contact")]
        public int CustomerAdditionalContactID { get; set; }

        [Required, DisplayName("From Site")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public int FromSiteID { get; set; }

        [Required, DisplayName("To Site")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public int ToSiteID { get; set; }

        [Required, DisplayName("Scheduled Date"), DataType(DataType.Date)]
        public DateTime ScheduledDate { get; set; }

        [DisplayName("Vehicle")]
        public int? VehicleID { get; set; }

        [DisplayName("Driver")]
        public int? EmployeeID { get; set; }

        [DisplayName("Trailer 1")]
        public int? Trailer1VehicleID { get; set; }

        [DisplayName("Trailer 2")]
        public int? Trailer2VehicleID { get; set; }

        [DisplayName("Departure Date/Time"), DataType(DataType.DateTime)]
        public DateTime? DepartureDateTime { get; set; }

        [DisplayName("Arrival Date/Time"), DataType(DataType.DateTime)]
        public DateTime? ArrivalDateTime { get; set; }

        [DisplayName("Triton Vehicle")]
        public bool? IsTritonVehicle { get; set; }

        [DisplayName("Trip Type")]
        public int TripTypeLCID { get; set; }

        [DisplayName("Tariff Type")]
        public int? TarrifTypeLCID { get; set; }

        public decimal? Tonnage { get; set; }

        [DisplayName("Tonnage Amount")]
        public decimal? TonnageAmount { get; set; }

        [DisplayName("Total Ex VAT")]
        public decimal? TotalExVAT { get; set; }

        [DisplayName("Customer Order No")]
        public string CustomerOrderNo { get; set; }

        [Required]
        [DisplayName("Created By")]
        public int CreatedByUserID { get; set; }

        [Required]
        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }

        public int CustomerIDTbl { get; set; }

        [DisplayName("Account No")]
        public string AccountCode { get; set; }
        [DisplayName("Branch")]
        public int BranchID { get; set; }
        public int? CustomerStatusID { get; set; }

        [DisplayName("Customer Name")]
        public string Name { get; set; }
        public bool LinkedAccount { get; set; }
        public int? LinkedCustomerID { get; set; }
        public bool FWSystemAccount { get; set; }
        public bool InternalAccount { get; set; }
        [DisplayName("Last Increased")]
        public DateTime? LastIncreaseDate { get; set; }
        [DisplayName("Next Increase")]
        public DateTime? NextIncreaseDate { get; set; }
        public string Contact { get; set; }
        [DisplayName("Tel Landline")]
        public string TelNo { get; set; }
        [DisplayName("Tel Fax")]
        public string FaxNo { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Tel Cell")]
        public string CellNo { get; set; }
        [DisplayName("Address Line 1")]
        public string AddLine1 { get; set; }
        [DisplayName("Address Line 2")]
        public string AddLine2 { get; set; }
        [DisplayName("Address Line 3")]
        public string AddLine3 { get; set; }
        [DisplayName("Address Line 4")]
        public string AddLine4 { get; set; }
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }
        public bool? MarkforClosure { get; set; }
        public int? StatusID { get; set; }
        public int CustomerAccountTypeID { get; set; }
        public string FWRateAccCode { get; set; }
        public string FWRepCode { get; set; }
        public bool? HasUniques { get; set; }
        public decimal? Insurance { get; set; }
        public int VolRatio { get; set; }
        public string Swat { get; set; }
        public decimal? Avg { get; set; }
        public decimal? Compliance { get; set; }
        public int? RateClassID { get; set; }
        [DisplayName("Created")]
        public DateTime? AccountCreatedDate { get; set; }
        public decimal? SixMonthCompliance { get; set; }
        public int? InternalDepartmentID { get; set; }
        public string RevisedAnvDate { get; set; }
        public bool Exclusion { get; set; }
        public bool hasFuelOnSundries { get; set; }
        public string PropAddress1 { get; set; }
        public string PropAddress2 { get; set; }
        public string PropAddress3 { get; set; }
        public string PropAddress4 { get; set; }
        public string PropTel { get; set; }
        public string PropFax { get; set; }
        public string PropPostalCode { get; set; }
        public int CustomerCommisionTypeID { get; set; }
        public bool hasFixedPerc { get; set; }
        public decimal? FixedPerc { get; set; }
        public int? PaymentProfileID { get; set; }
        public bool ExcludeTargetCorrection { get; set; }
        public bool? PODVerify { get; set; }
        public int? VerticalMarketID { get; set; }
        public int? SubVerticalMarketID { get; set; }
        public int? CustomerTradeStatusID { get; set; }
        public int? SaleTypeID { get; set; }


        public int? CustomerStatusLCID { get; set; }

        public string Country { get; set; }

        public int CustomerAccountTypeLCID { get; set; }

        public string AnvDate { get; set; }

        public string BillingKey { get; set; }

        public int CountryID { get; set; }

        public int TarrifCodeLCID { get; set; }

        [Key]
        public int UserID { get; set; }

        [DisplayName("Username")]
        public string UserName { get; set; }

        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public int FromSiteIDTbl { get; set; }

        [DisplayName("From Code")]
        public string FromSiteName { get; set; }

        [DisplayName("From Site Name")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string FromSiteCustomerName { get; set; }

        [DisplayName("From Address 1")]
        public string FromAddress1 { get; set; }

        [DisplayName("From Address 2")]
        public string FromAddress2 { get; set; }

        [DisplayName("FromAddress 3")]
        public string FromAddress3 { get; set; }

        public string FromCity { get; set; }

        [DisplayName("From Postal")]
        public string FromZip { get; set; }

        public int? FromStateAcronymID { get; set; }

        public int? FromCountryID { get; set; }

        [DisplayName("From Tel No")]
        public string FromPhoneNumber { get; set; }

        public decimal? FromLatitude { get; set; }

        public decimal? Longitude { get; set; }

        public int ToSiteIDTbl { get; set; }

        [DisplayName("To Code")]
        public string ToSiteName { get; set; }

        [DisplayName("To Site Name")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string ToSiteCustomerName { get; set; }

        [DisplayName("To Address 1")]
        public string ToAddress1 { get; set; }

        [DisplayName("To Address 2")]
        public string ToAddress2 { get; set; }

        [DisplayName("To Address 3")]
        public string ToAddress3 { get; set; }

        public string ToCity { get; set; }

        [DisplayName("ToPostal")]
        public string ToZip { get; set; }

        public int? ToStateAcronymID { get; set; }

        public int? ToCountryID { get; set; }

        [DisplayName("To Tel No")]
        public string ToPhoneNumber { get; set; }

        public decimal? ToLatitude { get; set; }

        public decimal? ToLongitude { get; set; }

        public long DeliveryScheduleID { get; set; }

        [DisplayName("Estimated Departure")]
        public DateTime? EstimatedDepartureDateTime { get; set; }

        [DisplayName("Estimated Arrival")]
        public DateTime? EstimatedArrivalDateTime { get; set; }

        [DisplayName("Estimated Created By")]
        public int? EstimatedCreatedByUserID { get; set; }

        [DisplayName("Estimated Created On")]
        public DateTime? EstimatedCreatedOn { get; set; }

        [DisplayName("Actual Departure")]
        public DateTime? ActualDepartureDateTime { get; set; }

        [DisplayName("Actual Arrival")]
        public DateTime? ActualArrivalDateTime { get; set; }

        [DisplayName("Actual Created By")]
        public int? ActualCreatedByUserID { get; set; }

        [DisplayName("Actual Created On")]
        public DateTime? ActualCreatedOn { get; set; }

        public DateTime? CollectionArrivalDateTime { get; set; }
        public DateTime? CollectionDepartureDateTime { get; set; }
        public DateTime? DestinationArrivalDateTime { get; set; }
        public DateTime? DestinationDepartureDateTime { get; set; }

        [DisplayName("Employee Code")]
        public string CurrentEmployeeCode { get; set; }

        [DisplayName("Employee Name")]
        public string LeaveDisplayName { get; set; }

        public int? DeliveriesSubContractorID { get; set; }

        public int? PurchaseOrderID { get; set; }

        public long? DeliveryVehicleID { get; set; }
        public string Registration { get; set; }
        public long? StartODO { get; set; }
        public long? EndODO { get; set; }
        public int? Sequence { get; set; }
        public string SupplierName { get; set; }

        public string FromToSite { get; set; }

        public string FromToCity { get; set; }

        [DisplayName("Fuel Litres")]
        public decimal? ActualFuelLitre { get; set; }

        [DisplayName("Fuel Value (R)")]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal? FuelValue { get; set; }

        [DisplayName("Trip Fuel")]
        public decimal? TripFuel { get; set; }

        [DisplayName("Child DeliveryID")]
        public int? ChildDeliveryID { get; set; }

        [DisplayName("Status LCID")]
        public int? StatusLCID { get; set; }

        public int? InvoiceID { get; set; }

        public long? SiteScheduleCalendarID { get; set; }

        [DisplayName("Invoice No")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string InvoiceNo { get; set; }

        [DisplayName("Invoice Date")]
        public DateTime? InvoiceDate { get; set; }

        public long TripDeliveryID { get; set; }

        [DisplayName("Trip Total Ex Vat")]
        public decimal? TripTotalExVat { get; set; }

        [DisplayName("Trip Delivery Note")]
        public string TripDeliveryNote { get; set; }

        [DisplayName("Base Rate")]
        public decimal BaseRate { get; set; }

        [DisplayName("Delivery Type")]
        public int TripDeliveryTypeLCID { get; set; }

        [DisplayName("Trip Tonnage")]
        public decimal TripTonnage { get; set; }

        [DisplayName("Trip Type Name")]
        public string TripTypeName { get; set; }

        public DateTime? TripDeletedOn { get; set; }

        [DisplayName("CHEP No")]
        public string CHEPNo { get; set; }

        [DisplayName("Collected")]
        public int? Collected { get; set; }

        [DisplayName("To Collect")]
        public int? ToCollect { get; set; }

        [DisplayName("Rate Per Ton")]
        public decimal? RatePerTon { get; set; } // decimal(18,2), null

        public int? SupplierID { get; set; }

        public int? TripNameID { get; set; } // int, null

        [DisplayName("Trip Name")]
        public string TripName { get; set; } // varchar(50), null

        [DisplayName("Starting Bid")]
        public double? MaxBid { get; set; } // float, null

        [DisplayName("Bidding Closing Date")]
        public DateTime? CutOffDateTime { get; set; } // datetime, null

        public long DeliveryOpenForBidID { get; set; }

        [DisplayName("Load Con No.")]
        public string LoadConNo { get; set; } // varchar(50), null

        [DisplayName("Delivery Status")]
        public string DeliveryStatus { get; set; } // varchar(50), null

        public int? DeliveryPalletID { get; set; } // varchar(50), null

        public DateTime? LegDate { get; set; }

        public DateTime? SalaryDate { get; set; }

        public int? LineHaulTrailerTypeLCID { get; set; }
    }



    public class vw_DeliveriesDayModifierDate : vw_Deliveries
    {
        public DateTime AdjustedScheduleDate { get; set; }
    }
}
