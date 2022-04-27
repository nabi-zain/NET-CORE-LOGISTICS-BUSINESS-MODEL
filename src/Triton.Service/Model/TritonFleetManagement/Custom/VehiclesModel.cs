using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class VehiclesModel
    {
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
        public string RegistrationNumber { get; set; }
        public string FleetNumber { get; set; }
        public string VinNumber { get; set; }
        public string EngineNumber { get; set; }
        public int VehicleYear { get; set; }
        public string GVM { get; set; }
        public int ServiceIntervalLCID { get; set; }
        public int? TailLiftTypeLCID { get; set; }
        public bool TailLift { get; set; }
        public int VehicleClassLCID { get; set; }
        public int VehicleBrandLCID { get; set; }
        public int ServiceCategoryTypeID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }

    }
}
