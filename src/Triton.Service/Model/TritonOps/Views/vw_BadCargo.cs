using System.ComponentModel;

namespace Triton.Model.TritonOps.Views
{
    public class vw_BadCargo
    {
        [Dapper.Contrib.Extensions.Key]

        public string WaybillNo { get; set; }

        [DisplayName("Customer")]
        public string Name { get; set; }

        [DisplayName("Branch")]
        public string BranchFullName { get; set; }

        [DisplayName("Category")]
        public string CategoryText { get; set; }

        public int BadCargoCategoryID { get; set; }

        public byte[] FileData { get; set; }

        public int CustomerID { get; set; }

        public int NewCategory { get; set; }

        public int BranchID { get; set; }
        public string Comments { get; set; }

        public decimal Volume { get; set; }
        public decimal TotalMass { get; set; }
        public decimal ChargeMass { get; set; }
        public int BadCargoID { get; set; }
        public int BadCargoImageID { get; set; }

    }
}
