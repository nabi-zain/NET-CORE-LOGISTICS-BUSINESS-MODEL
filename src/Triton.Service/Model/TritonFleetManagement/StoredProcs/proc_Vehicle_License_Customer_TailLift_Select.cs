using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.StoredProcs
{
    public class proc_Vehicle_License_Customer_TailLift_Select
    {
        public string LCTailDetail { get; set; }
        public string LCServiceDtail { get; set; }
        public string LCVehicleClassDetail { get; set; }
        public string LCVehicleBrandDetail { get; set; }
        public int VehicleID { get; set; }
        public int CustomerID { get; set; }
        public string RegistrationNumber { get; set; }
        public string FleetNumber { get; set; }
        public string VinNumber { get; set; }
        public string EngineNumber { get; set; }
        public int VehicleYear { get; set; }
        public int CreatedByUserID { get; set; }
        public int DeletedByUserID { get; set; }
        public string GVM { get; set; }
        public int ServiceIntervalLCID { get; set; }
        public int TailLiftTypeLCID { get; set; }
        public int VehicleBrandLCID { get; set; }
        public int VehicleClassLCID { get; set; }
        public bool TailLift { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime Expiry { get; set; }
        public string tlsDescription { get; set; }
        public DateTime tlsServiceDate { get; set; }
        public string cName { get; set; }
    }
}
