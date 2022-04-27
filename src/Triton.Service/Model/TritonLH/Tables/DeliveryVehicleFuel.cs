using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveryVehicleFuel")]
    public class DeliveryVehicleFuel
    {
        [Dapper.Contrib.Extensions.Key]
        public long DeliveryVehicleFuelID { get; set; } // bigint, not null
        public long DeliveryID { get; set; } // bigint, not null

        [DisplayName("Fuel Type")]
        public int? FuelTypeLCID { get; set; } // int, null

        public decimal? Litres { get; set; } // decimal(18,0), null
        public decimal? Cost { get; set; } // money, null
        public int CreatedByUserID { get; set; } // int, not null
        public DateTime CreatedOn { get; set; } // datetime, not null
        public int? DeletedByUserID { get; set; } // int, null
        public DateTime? DeletedOn { get; set; } // datetime, null
        public int? FuelMileage { get; set; }
        public DateTime? FillDate { get; set; } 

    }

}
