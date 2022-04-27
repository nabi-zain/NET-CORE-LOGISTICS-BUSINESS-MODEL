using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.TritonOps.Custom
{
    public class EmployeeVehicleMapsModels
    {
        public EmployeeVehicleMaps EmployeeVehicleMaps { get; set; }

        public Employees Employees { get; set; }

        public VehicleRegMaps VehicleRegMaps { get; set; }
    }
}
