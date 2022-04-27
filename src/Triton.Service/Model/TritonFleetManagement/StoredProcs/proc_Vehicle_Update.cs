using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.StoredProcs
{
    public class proc_Vehicle_Update
    {
        [Required]
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
        [Required]
        public bool TailLift { get; set; }
        public int? TailLiftTypeLCID { get; set; }
        [Required]
        public int VehicleBrandLCID { get; set; }
        [Required]
        public int VehicleClassLCID { get; set; }
        public string Description { get; set; }
        public DateTime? ServiceDate { get; set; }
        [Required]
        public string LicenseNumber { get; set; }
        [Required]
        public DateTime Expiry { get; set; }
    }
}
