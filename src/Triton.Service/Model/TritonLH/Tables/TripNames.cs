using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("TripNames")]
    public class TripNames
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public int TripNameID { get; set; }

        [Required, DisplayName("Trip Name")]
        public string TripName { get; set; }

        [Required, DisplayName("Transit Hours")]
        public int TransitHours { get; set; }

        [Required, DisplayName("Created By")]
        public int CreatedbyID { get; set; }

        [Required, DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }
    }
}
