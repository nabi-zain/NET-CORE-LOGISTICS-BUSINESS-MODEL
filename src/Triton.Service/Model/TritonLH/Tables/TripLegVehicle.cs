using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.Tables
{
    [Table("TripLegVehicle")]
    public class TripLegVehicle
    {
        [Dapper.Contrib.Extensions.Key]
        public int TripLegVehicleID { get; set; }
        [Required]
        public int TripDeliverySiteMapID { get; set; }
        [Required]
        public int TrailerLCID { get; set; }
        [Required]
        public decimal Consumption { get; set; }
        [Required]
        public TimeSpan DepartureTime { get; set; }
        public bool Active { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
