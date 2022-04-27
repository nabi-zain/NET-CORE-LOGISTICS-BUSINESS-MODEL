using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.TritonVehicles.Custom
{
    class VehicleTypesModel
    {
        VehicleTypes VehicleType { get; set; }
        VehicleClasses VehicleClasses { get; set; }
      
        ///TO add DB
        ///tblFuelType FuelType{gt;set;}

    }
}
