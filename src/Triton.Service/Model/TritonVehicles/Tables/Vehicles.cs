using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonVehicles.Tables
{
    [Table("Vehicles")]
    public class Vehicles
    {
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public int VehicleID { get; set; }

        public int? POVehicleID { get; set; }
        public int? VehicleOwnershipID { get; set; }
        public int? VehicleTypeID { get; set; }
        public int? StatusID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? StatusDate { get; set; }
        public int? VehicleConfigID { get; set; }
        public string ChassisNumber { get; set; }
        public string EngineNumber { get; set; }
        public decimal? OverrideConsumption { get; set; }
        public int? Tare { get; set; }
        public int? GVM { get; set; }
        public int? Capacity { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? OrderBy { get; set; }
        public int? OverrideVehicleClassID { get; set; }
    }
}