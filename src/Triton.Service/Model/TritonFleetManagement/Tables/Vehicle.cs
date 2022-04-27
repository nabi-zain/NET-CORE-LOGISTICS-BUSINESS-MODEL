using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        public int VehicleID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public string FleetNumber { get; set; }
        [Required]
        public string VinNumber { get; set; }
        [Required]
        public string EngineNumber { get; set; }
        [Required]
        public int VehicleYear { get; set; }
        [Required]
        public string GVM { get; set; }
        [Required]
        public int ServiceIntervalLCID { get; set; }
        public int? TailLiftTypeLCID { get; set; }
        public bool TailLift { get; set; }
        [Required]
        public int VehicleClassLCID { get; set; }
        [Required]
        public int VehicleBrandLCID { get; set; }
        [Required]
        public int CreatedByUserID { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
