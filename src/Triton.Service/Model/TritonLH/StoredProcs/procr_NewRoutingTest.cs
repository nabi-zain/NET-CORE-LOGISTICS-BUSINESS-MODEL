using System;
using System.Collections.Generic;

namespace Triton.Model.TritonLH.Tables
{
    public class procr_NewRoutingTest
    {
        public long TripDeliveryID { get; set; } // bigint, not null
        public DateTime ScheduledDate { get; set; } // datetime, not null
        public decimal? TripTotalExVat { get; set; } // decimal(18,2), null
        public int? TripDeliveryTypeLCID { get; set; } // int, null
        public decimal? TripTonnage { get; set; } // decimal(18,2), null
        public int? TripNameID { get; set; } // int, null
        public string TripName { get; set; } // varchar(50), not null
        public int TransitHours { get; set; } // int, not null
        public long DeliveryID { get; set; } // bigint, not null
        public int? FromSiteID { get; set; } // int, null
        public int? ToSiteID { get; set; } // int, null
        public bool? IsTritonVehicle { get; set; } // bit, null
        public int? TripTypeLCID { get; set; } // int, null
        public int? TarrifTypeLCID { get; set; } // int, null
        public decimal? Tonnage { get; set; } // decimal(18,0), null
        public decimal? TonnageAmount { get; set; } // money, null
        public decimal? TotalExVAT { get; set; } // money, null
        public int? LineHaulTrailerTypeLCID { get; set; } // int, null
        public decimal? Kilometers { get; set; } // decimal(18,2), null
        public int DeliverySeqNo { get; set; } // int, not null
        public int? Seq { get; set; } // int, null
        public int? LineHaulManifestID { get; set; } // int, null
        public int LinehaulManifestID { get; set; } // int, not null
        public string LinehaulManifestNo { get; set; } // varchar(50), null
        public DateTime? DateLHManifest { get; set; } // date, null
        public string DateLHLeft { get; set; } // varchar(8), null
        public string DateLHArr { get; set; } // varchar(8), null
        public string DateLHExp { get; set; } // varchar(8), null
        public string TimeLHLeft { get; set; } // varchar(4), null
        public string TimeLHArr { get; set; } // varchar(4), null
        public string TimeLHExp { get; set; } // varchar(4), null
        public DateTime? StampLHLeft { get; set; } // datetime, null
        public DateTime? StampLHArr { get; set; } // datetime, null
        public DateTime? StampLHExp { get; set; } // datetime, null
        public int? FromBranchID { get; set; } // int, null
        public int? ToBranchID { get; set; } // int, null
        public string FWDriver { get; set; } // varchar(50), null
        public string FWVehicle { get; set; } // varchar(50), null
        public string FWTruckRoute { get; set; } // varchar(50), null
        public int? LinehaulManifestStatusID { get; set; } // int, null
        public string Seal1 { get; set; } // varchar(50), null
        public string Seal2 { get; set; } // varchar(50), null
        public string Seal3 { get; set; } // varchar(50), null
        public string Seal4 { get; set; } // varchar(50), null
        public string FWIDCapture { get; set; } // varchar(50), null
        public string FWIDModify { get; set; } // varchar(50), null
        public decimal? TotalMass { get; set; } // decimal(18,2), null
        public int? TotalQty { get; set; } // int, null
        public decimal? TotalValue { get; set; } // decimal(18,2), null
        public decimal? TotalVolume { get; set; } // decimal(18,2), null
        public decimal? TotalActualVolume { get; set; } // decimal(18,2), null
        public int? SubContractorID { get; set; } // int, null
        public string SubContractorDocNo { get; set; } // varchar(50), null
        public string SubContractorLoadType { get; set; } // varchar(50), null
        public string SubContractorServType { get; set; } // varchar(50), null
        public string SubContractorRateType { get; set; } // varchar(50), null
        public string VisualCapacity { get; set; } // varchar(3), null
        public string FromBranch { get; set; } // varchar(150), null
        public string ToBranch { get; set; } // varchar(150), null
        public string LegFromBranch { get; set; } // varchar(150), null
        public string LegToBranch { get; set; } // varchar(150), null
        public int Capacity { get; set; } // int, not null
        public decimal? ManEstChargeMass { get; set; } // decimal(18,2), null
    }
}
