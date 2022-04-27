using System.ComponentModel;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Branch_Vehicle_Productivity_Select
    {
        public int BranchID { get; set; }

        [DisplayName("Branch Name")]
        public string BranchFullName { get; set; }

        [DisplayName("Del %")]
        public decimal DelPerc { get; set; }

        [DisplayName("Col %")]
        public decimal ColPerc { get; set; }

        [DisplayName("Total Charge Mass")]
        public decimal TotalChargeMass { get; set; }

        [DisplayName("Total Veh Cap")]
        public decimal TotalVehicleCapacity { get; set; }

        [DisplayName("Total")]
        public decimal Total { get; set; }
    }
}
