using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.TritonVehicles.Custom
{
    class VehicleMileageTrackerModel
    {
        Vehicles Vehicle { get; set; }
        Users User { get; set; }
    }
}
