using System.ComponentModel;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_DeliveriesVehicles_VehicleMonthlySummary_Select
    {
        [DisplayName("Year")]
        public int VehicleYear { get; set; }

        [DisplayName("Month")]
        public int VehicleMonth { get; set; }

        [DisplayName("Triton Vehicle")]
        public int OwnVehicle { get; set; }

        [DisplayName("Subby")]
        public int Subby { get; set; }

        [DisplayName("Un-assiged")]
        public int UnAssigned { get; set; }
    }
}
