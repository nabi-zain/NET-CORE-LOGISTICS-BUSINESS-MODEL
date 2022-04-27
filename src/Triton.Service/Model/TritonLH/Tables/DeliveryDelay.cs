using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveryDelay")]
    public class DeliveryDelay
    {
        [Dapper.Contrib.Extensions.Key]
        public int DeliveryDelayID { get; set; }
        [Required]
        public long DeliveryID { get; set; }
        [Required]
        public int DelayLCID { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public int CreatedByUserID { get; set; }
    }
}
