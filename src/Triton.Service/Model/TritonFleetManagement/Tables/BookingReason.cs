using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("BookingReason")]
    public class BookingReason
    {
        [Key]
        public int BookingReasonsID { get; set; }

        [Required]
        public int BookingsID { get; set; }

        [Required]
        public string BookingReasonLCID { get; set; }

        public DateTime ? DeletedOn { get; set; }
        public int ? DeletedByUserID { get; set; }
    }
}
