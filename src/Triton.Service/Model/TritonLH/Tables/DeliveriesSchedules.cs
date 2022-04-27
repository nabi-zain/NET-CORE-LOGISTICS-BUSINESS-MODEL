using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesSchedules")]
    public class DeliveriesSchedules
    {
        [Key]
        public long DeliveryScheduleID { get; set; }
        public long DeliveryID { get; set; }

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

        [DisplayName("Collection Arrival")]
        public DateTime? CollectionArrivalDateTime { get; set; } // datetime, null

        [DisplayName("Collection Departure")]
        public DateTime? CollectionDepartureDateTime { get; set; } // datetime, null

        [DisplayName("Destination Arrival")]
        public DateTime? DestinationArrivalDateTime { get; set; } // datetime, null

        [DisplayName("Destination Departure")]
        public DateTime? DestinationDepartureDateTime { get; set; } // datetime, null


        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }
    }
}
