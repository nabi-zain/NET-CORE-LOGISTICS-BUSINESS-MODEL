using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.TritonVehicles.Custom
{
    class VehicleConfigsModel
    {
        VehicleClasses VehicleConfig { get; set; }
        tblStatus Status { get; set; }
    }
}
