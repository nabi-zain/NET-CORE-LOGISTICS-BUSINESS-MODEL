using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonVehicles.Views
{
    public class CurrentVehicles
    {
        public int VehicleID { get; set; }
        public int? POVehicleID { get; set; }
        public string Registration { get; set; }

        [DisplayName("Vehicle Type")]
        public string VehicleType { get; set; }

        [DisplayName("Vehicle Type Desc")]
        public string VehicleTypeDesc { get; set; }

        [DisplayName("Branch")]
        public string BranchFullName { get; set; }

        public int? StatusID { get; set; }
        public DateTime? StatusDate { get; set; }
        public string DBitNumber { get; set; }

        [DisplayName("Purchase Date")]
        public DateTime? DatePurchased { get; set; }

        [DisplayName("Original Cost")]
        public decimal? OriginalCost { get; set; }

        public string FinancialAgreementNo { get; set; }

        [DisplayName("Trade In")]
        public decimal? TradeIn { get; set; }

        public decimal? Retail { get; set; }
        public decimal? Value { get; set; }
        public decimal? RealDepreciationRate { get; set; }
        public decimal? SalesValueExVat { get; set; }
        public int? BranchID { get; set; }
        public int? VehicleTypeID { get; set; }
        public decimal? Mileage { get; set; }
        public string Model { get; set; }
        public string Class { get; set; }
        public string Config { get; set; }
        public int? VehConfigID { get; set; }
        public int? VehicleClassID { get; set; }
        public int? TonnageID { get; set; }
        public string Tonnage { get; set; }

        [DisplayName("Running Cost")]
        public string RunningCost { get; set; }

        [DisplayName("Branch Name")]
        public string BranchName { get; set; }

        [DisplayName("Total KM")]
        public int? TotalKm { get; set; }

        [DisplayName("Total Years")]
        public int? TotalYears { get; set; }

        [DisplayName("Top Mileage")]
        public decimal TopMileage { get; set; }

        public string RunningCostExc { get; set; }
        public DateTime? OrderBy { get; set; }

        [DisplayName("Service Interval")]
        public int? ServiceInterval { get; set; }

        [DisplayName("Target Con")]
        public decimal? TargetConsumption { get; set; }

        public int? Capacity { get; set; }
    }
}