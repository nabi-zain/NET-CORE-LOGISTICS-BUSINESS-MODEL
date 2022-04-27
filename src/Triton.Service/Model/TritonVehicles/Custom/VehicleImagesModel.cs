using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.TritonVehicles.Custom
{
    class VehicleImagesModel
    {

        Vehicles Vehicles { get; set; }
        VehicleImages VehicleImagesCategory { get; set; } 
        VehicleImages UserUploaded { get; set; }
    }
}
