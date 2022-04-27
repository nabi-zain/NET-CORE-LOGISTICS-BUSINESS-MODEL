using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.TritonOps.Custom
{
    public class CCLEmployeeVehicleMapModels
    {
        public CCLEmployeeVehicleMap CCLEmployeeVehicleMap { get; set; }

        public VehicleRegMaps Vehicles { get; set; }

        public VehicleRegMaps Trailer1 { get; set; }

        public VehicleRegMaps Trailer2 { get; set; }

        public Employees Employees { get; set; }
    }
}