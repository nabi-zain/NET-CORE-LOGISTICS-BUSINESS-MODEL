using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class procr_VehicleServiceHistory
    {
        public int VehicleID { get; set; }
        public int BranchID { get; set; }
        public string BranchFullName { get; set; }
        public string Registration { get; set; }
          [DisplayName("Vehicle Type")]
        public string VehicleType { get; set; }
        public string Class { get; set; }
          [DisplayName("Service Interval")]
        public int ServiceInterval { get; set; }
         [DisplayName("Last Serviced Mileage")]
        public Int64 POMileage { get; set; }
        public Int64? NextServiceMileage { get; set; }
          [DisplayName("Current Mileage")]
        public Int64 Mileage { get; set; }
          public DateTime CreatedDateTime { get; set; }
        public Int64? Variance { get; set; }
        public bool IsOverDue { get; set; }

    }

    public class procr_VehicleServiceHistoryFMO
    {
        public int VehicleID { get; set; }
        public int BranchID { get; set; }
        public string BranchFullName { get; set; }
        public string Registration { get; set; }
        [DisplayName("Vehicle Type")]
        public string VehicleType { get; set; }
        public string Class { get; set; }
        [DisplayName("Service Interval")]
        public int ServiceInterval { get; set; }
        [DisplayName("Last Serviced Mileage")]
        public Int64 POMileage { get; set; }
        public Int64 FMOMileage { get; set; }
        public Int64? NextServiceMileage { get; set; }
        [DisplayName("Current Mileage")]
        public Int64 Mileage { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Int64? Variance { get; set; }
        public bool IsOverDue { get; set; }

    }
}
