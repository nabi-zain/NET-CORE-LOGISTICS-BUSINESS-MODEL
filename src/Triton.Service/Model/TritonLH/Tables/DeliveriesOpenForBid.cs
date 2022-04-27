using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesOpenForBid")]
    public class DeliveriesOpenForBid
    {
        [Dapper.Contrib.Extensions.Key]
        [Required, DisplayName("Delivery Open For Bid ID")]
        public long DeliveryOpenForBidID { get; set; } // bigint, not null

        [Required, DisplayName("Delivery ID")]
        public long DeliveryID { get; set; } // bigint, not null

        [Required, DisplayName("Max Bid")]
        public double MaxBid { get; set; } // float, not null

        [DisplayName("Cut Off Date")]
        public DateTime? CutOffDateTime { get; set; } // datetime, null

        public long? DeletedBy { get; set; } // bigint, null
              
        public DateTime? DeletedOn { get; set; } // datetime, null
    }

}
