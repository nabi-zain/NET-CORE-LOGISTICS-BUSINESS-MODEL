using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.TritonVehicles.Tables
{
    [Table("VehicleTypes")]
    public class VehicleTypes
    {
        [Key]
        public int VehicleTypeID { get; set; }
        [DisplayName("Vehicle Type")]
        public string VehicleType { get; set; }
        public int? VehicleClassID { get; set; }
        public int? VehicleTonnageID { get; set; }
        public int? Tare { get; set; }
        public decimal? GeneralConsumption { get; set; }
        public int? TankCapacity { get; set; }
        public int? ServiceInterval { get; set; }
        public int? NoofTyres { get; set; }
        public decimal? TargetConsumption { get; set; }
        public decimal? ExcessValue { get; set; }
        public int? TotalKm { get; set; }
        public int? TotalYears { get; set; }
        public int StatusID { get; set; }
        public bool ActiveReplacement { get; set; }
        public int? FuelTypeID { get; set; }
    }
}
