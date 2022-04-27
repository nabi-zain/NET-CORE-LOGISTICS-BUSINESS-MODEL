using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("TripDeliverySiteMaps")]
    public class TripDeliverySiteMaps
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public int TripDeliverySiteMapID { get; set; }

        [Required]
        public int TripNameID { get; set; }

        [Required, DisplayName("Delivery Sequence")]
        public int DeliverySeqNo { get; set; }

        [Required, DisplayName("From Site")]
        public int FromSiteID { get; set; }

        [Required, DisplayName("To Site")]
        public int ToSiteID { get; set; }

        [DisplayName("Transit Hours")]
        public TimeSpan? TransitHours { get; set; }

        [DisplayName("Grace")]
        public TimeSpan? Grace { get; set; }

        public int Kilometers { get; set; }

        [Required, DisplayName("Day Modifier")]
        public int DayModifier { get; set; }

        [Required, DisplayName("Created By")]
        public int CreatedByUserID { get; set; }

        [Required, DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }
    }
}
