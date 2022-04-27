using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblVehicleCheckModels
    {
      
        public Vehicles vehicle { get; set; }
     
        public tblVehicleCheck VehiclesCheck { get; set; }


        public tblUsers User { get; set; }

    }

  
}
