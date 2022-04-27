using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("Deliveries")]
    public class Deliveries
    {
        //public Deliveries()
        //{
        //    IsTritonVehicle = true;
        //}

        [Dapper.Contrib.Extensions.Key]
        [Required]
        public long DeliveryID { get; set; }

        [Required]
        public long TripDeliveryID { get; set; }

        [DisplayName("Leg Date")]
        public DateTime? LegDate { get; set; }

        [DisplayName("Delivery Note No")]
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

        //[Required, DisplayName("Scheduled Date"), DataType(DataType.Date)]
        //public DateTime ScheduledDate { get; set; }

        //[DisplayName("Vehicle")]
        //public int? VehicleID { get; set; }

        //[DisplayName("Driver")]
        //public int? EmployeeID { get; set; }

        //[DisplayName("Trailer 1")]
        //public int? Trailer1VehicleID { get; set; }

        //[DisplayName("Trailer 2")]
        //public int? Trailer2VehicleID { get; set; }

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

        [DisplayName("Base Rate")]
        public decimal? TonnageAmount { get; set; }

        [DisplayName("Total excl. VAT")]
        public decimal? TotalExVAT { get; set; }

        [DisplayName("Rate per Ton")]
        public decimal? RatePerTon { get; set; }

        [DisplayName("Customer Order No")]
        public string CustomerOrderNo { get; set; }

        [DisplayName("Invoice No")]
        public int? InvoiceID { get; set; }

        public int? StatusLCID { get; set; }

        [DisplayName("Trailer Type")]
        public int? LineHaulTrailerTypeLCID { get; set; }

        public decimal? Kilometers { get; set; }

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

        public long? SiteScheduleCalendarID { get; set; }

        [DisplayName("Reason")]
        public int? DeleteReasonLCID { get; set; }


        [DisplayName("Load Con No.")]
        public string LoadConNo { get; set; } // varchar(50), null

        public int? FromCustomerSiteMapID { get; set; }
        public int? ToCustomerSiteMapID { get; set; }
        public long? CustomerUniqueRateID { get; set; }
        public DateTime? SalaryDate { get; set; }

        public long? PreviousDeliveryID { get; set; }
        public long? PreviousFuelDeliveryID { get; set; }

        [DisplayName("Financial Status")]
        public int DeliveryFinancialStatusLCID { get; set; }

        public bool Locked { get; set; }
    }
}