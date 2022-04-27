using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesBids")]
    public class DeliveriesBids
    {
        [Dapper.Contrib.Extensions.Key]
        [Required, DisplayName("Delivery Bid ID")]
        public long DeliveryBidID { get; set; } // bigint, not null

        [Required, DisplayName("Delivery Open For Bid ID")]
        public long DeliveryOpenForBidID { get; set; } // bigint, not null

        [Required, DisplayName("Customer ID")]
        public long UserID { get; set; } // bigint, not null

        [Required, DisplayName("Bid Amount")]
        public double BidAmount { get; set; } // float, not null

        [Required, DisplayName("Bid Date")]
        public DateTime BidDate { get; set; } // datetime, not null

        [DisplayName("Winning Bid")]
        public bool? WinningBid { get; set; } // bit, null        

    }
}
