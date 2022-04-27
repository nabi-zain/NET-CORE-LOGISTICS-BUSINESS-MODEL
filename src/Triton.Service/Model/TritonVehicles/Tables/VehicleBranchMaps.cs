using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonVehicles.Tables
{
    public class VehicleBranchMaps
    {
        public int VehicleBranchMap { get; set; }
        public int VehicleID { get; set; }
        public int BranchID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Comment { get; set; }
    }
}
