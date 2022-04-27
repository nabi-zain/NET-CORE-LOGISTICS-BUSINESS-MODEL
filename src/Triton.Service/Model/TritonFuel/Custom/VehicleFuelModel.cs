using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonFuel.Tables;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.TritonFuel.Custom
{
    public class VehicleFuelModel
    {
        public VehicleFuel VehicleFuel { get; set; }
        public Vehicles Vehicles { get; set; }
        public Employees Employees { get; set; }
        public LookUpCodes LookUpCodes { get; set; }
        public VehicleTypes VehicleTypes { get; set; }

    }
}
