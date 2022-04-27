using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesLegs")]
    public class DeliveriesLegs
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public long DeliveriesLegID { get; set; }

        [Required]
        public long ParentDeliveryID { get; set; }

        public long? ChildDeliveryID { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? DeletedByUserID { get; set; }
    }
}
