using System;

namespace Triton.Model.TritonOps.Tables
{
    public class LinehaulManifests
    {
        public int LinehaulManifestID { get; set; }
        public string LinehaulManifestNo { get; set; }
        public DateTime? DateLHManifest { get; set; }
        public string DateLHLeft { get; set; }
        public string DateLHArr { get; set; }
        public string DateLHExp { get; set; }
        public string TimeLHLeft { get; set; }
        public string TimeLHArr { get; set; }
        public string TimeLHExp { get; set; }
        public DateTime? StampLHLeft { get; set; }
        public DateTime? StampLHArr { get; set; }
        public DateTime? StampLHExp { get; set; }
        public int? FromBranchID { get; set; }
        public int? ToBranchID { get; set; }
        public string FWDriver { get; set; }
        public string FWVehicle { get; set; }
        public string FWTruckRoute { get; set; }
        public string Seal1 { get; set; }
        public string Seal2 { get; set; }
        public string Seal3 { get; set; }
        public string Seal4 { get; set; }
        public string FWIDCapture { get; set; }
        public string FWIDModify { get; set; }
        public decimal? TotalMass { get; set; }
        public int? TotalQty { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? TotalVolume { get; set; }
        public decimal? TotalActualVolume { get; set; }
        public int? SubContractorID { get; set; }
        public string SubContractorDocNo { get; set; }
        public string SubContractorLoadType { get; set; }
        public string SubContractorServType { get; set; }
        public string SubContractorRateType { get; set; }
        public string VisualCapacity { get; set; }
        public Int64 TripDeliveryID { get; set; }
    }
}
