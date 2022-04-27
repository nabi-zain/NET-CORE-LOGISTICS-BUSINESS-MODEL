using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonLH.Tables
{
    [Table("DeliveriesVehicles")]
    public class DeliveriesVehicles
    {
        [Dapper.Contrib.Extensions.Key]
        public long DeliveryVehicleID { get; set; }
        public long DeliveryID { get; set; }
        public int? EmployeeID { get; set; }
        public int? VehicleID { get; set; }
        public int? Trailer1VehicleID { get; set; }
        public int? Trailer2VehicleID { get; set; }
        public int? PurchaseOrderID { get; set; }
        public string Registration { get; set; }

        [DisplayName("Start ODO")]
        public long? StartODO { get; set; }

        [DisplayName("End ODO")]
        public long? EndODO { get; set; }

        [DisplayName("Fuel Litres")]
        public decimal? ActualFuelLitre { get; set; }

        [DisplayName("Fuel Value (R)")]
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal? FuelValue { get; set; }

        [DisplayName("Trip Fuel")]
        public decimal? TripFuel { get; set; }

        public bool IsTritonVehicle { get; set; }
        public int Sequence { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
       
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal? SubbyCost { get; set; }
        public string SubbyDriver { get; set; }
        public string SubbyCell { get; set; }
        public string ClientName { get; set; }
        public int? SupplierID { get; set; }
    }
}
