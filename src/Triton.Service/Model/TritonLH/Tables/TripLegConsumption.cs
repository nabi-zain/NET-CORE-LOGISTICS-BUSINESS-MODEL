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
    [Table("TripLegConsumption")]
    public class TripLegConsumption
    {
        [Dapper.Contrib.Extensions.Key]
        public int TripLegConsumptionID { get; set; }
        [Required]
        public int TripDeliverySiteMapID { get; set; }
        [Required]
        public int TrailerLCID { get; set; }
        public decimal Consumption { get; set; }
        public bool Active { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
