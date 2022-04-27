using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_EmployeeVehicle_FW_Variance_Select
    {
        public int FWRouteID { get; set; }

        public int? FWVehicleID { get; set; }

        public int? FWEmployeeID { get; set; }

        public string FWRoute { get; set; }

        public string FWRouteName { get; set; }

        public string FWVehicleReg { get; set; }

        public string FWCurrentEmployeeCode { get; set; }

        public int? RouteID { get; set; }

        public int? VehicleID { get; set; }

        public int? EmployeeID { get; set; }

        public string Route { get; set; }

        public string RouteName { get; set; }

        public string VehicleReg { get; set; }

        public string CurrentEmployeeCode { get; set; }

        public int? EmpMisMatch { get; set; }

        public int? VehMisMatch { get; set; }

        public int? RouteMisMatch { get; set; }

        public int? BranchID { get; set; }

        public string DelManifestNumber { get; set; }

        public DateTime DelManifestDate { get; set; }

        public int DeliveryManifestID { get; set; }

        public string ZoneController { get; set; }

        public int? DeliverySheetTotal { get; set; }

        public int? WaybillCount { get; set; }

        public int? Capacity { get; set; }

        public int? TotalMass { get; set; }

        public int? LoadVariance { get; set; }

        public string Note { get; set; }

        public string BranchAlias { get; set; }

        public string RouteNumber { get; set; }

        public bool? RouteActiveFlag { get; set; }

        public string FWJobProfile { get; set; }

        public string FWEmployeeActive { get; set; }

        public int? isSpare { get; set; }
    }
}