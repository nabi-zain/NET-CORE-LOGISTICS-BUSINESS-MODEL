using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("TripDelivery")]
    public class TripDelivery
    {
        [Dapper.Contrib.Extensions.Key]
        public long TripDeliveryID { get; set; }

        [Required, DisplayName("Scheduled Date"), DataType(DataType.Date)]
        public DateTime ScheduledDate { get; set; }

        [Required, DisplayName("Trip excl. VAT")]
        public decimal? TripTotalExVat { get; set; }

        [DisplayName("Trip Delivery Note")]
        public string TripDeliveryNote { get; set; }

        [DisplayName("Trip DeliveryType")]
        public int TripDeliveryTypeLCID { get; set; }

        [DisplayName("Base Rate")]
        public decimal? BaseRate { get; set; }

        [DisplayName("Trip Tonnage")]
        public decimal TripTonnage { get; set; }

        public int? TripNameID { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }
    }
}
