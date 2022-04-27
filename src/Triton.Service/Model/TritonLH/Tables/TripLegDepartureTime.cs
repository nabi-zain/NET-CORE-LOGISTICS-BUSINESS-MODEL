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
    [Table("TripLegDepartureTime")]
    public class TripLegDepartureTime
    {
        [Dapper.Contrib.Extensions.Key]
        public int TripLegDepartureTimeID { get; set; }
        public int TripDeliverySiteMapID { get; set; }

        [Required, DisplayName("Departure Time")]
        public TimeSpan DepartureTime { get; set; }
        public bool Active { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
