using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.TritonVehicles.Custom
{
    class VehiclesModel
    {
        Vehicles Vehicle { get; set; }
        VehicleTypes VehicleType { get; set; }
        VehicleConfigs VehicleConfigs { get; set; }
        VehicleClasses OverrideVehicleClassID { get; set; }

    }
}
