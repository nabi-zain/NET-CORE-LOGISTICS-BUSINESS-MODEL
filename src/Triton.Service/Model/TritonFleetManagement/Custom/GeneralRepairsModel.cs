using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class GeneralRepairsModel
    {
        public int BookingsID { get; set; }
        public string CustomerName { get; set; }
        public string RegistrationNumber { get; set; }
        public string FleetNumber { get; set; }
        public int VehicleYear { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleMake { get; set; }
        public string BookingReason { get; set; }
        public DateTime EstimatedArrival { get; set; }
    }
}
