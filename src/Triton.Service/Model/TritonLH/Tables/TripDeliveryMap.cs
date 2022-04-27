using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("TripDeliveryMap")]
    public class TripDeliveryMap
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public int TripDeliveryMapID { get; set; }

        [Required]
        public int TripNameID { get; set; }

        [Required]
        public int DeliveryID { get; set; }

        [Required, DisplayName("Trip Date")]
        public DateTime TripDate { get; set; }

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
