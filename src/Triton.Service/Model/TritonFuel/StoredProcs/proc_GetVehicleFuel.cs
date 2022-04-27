using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonFuel.StoredProcs
{
    public class proc_GetVehicleFuel
    {
        public string Registration { get; set; }
        public string DriverName { get; set; }
        public string CurrentEmployeeCode { get; set; }
        public int VehicleMileage { get; set; }
        public int PrevVehicleMileage { get; set; }
        public int OpeningPump { get; set; }
        public int ClosingPump { get; set; }
        public int CalculatedLitres { get; set; }
        public bool Variance { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Bowser { get; set; }
        public string FillType { get; set; }
        public string BranchFullName { get; set; }
        public int BranchID { get; set; }
        public string VehicleType { get; set; }
        public int CapturedLitres { get; set; }
        public int VehicleFuelID { get; set; }
    }
}
