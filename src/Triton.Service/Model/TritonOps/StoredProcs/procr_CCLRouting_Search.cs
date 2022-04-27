using System;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class procr_CCLRouting_Search
    {
        public DateTime? RouteDate { get; set; }
        public string DisplayName { get; set; }
        public string Alias { get; set; }
        public string SubContractorNo { get; set; }
        public string LinehaulManifestNo { get; set; }
        public long? LinehaulManifestID { get; set; }
        public int? TotalWaybills { get; set; }
        public decimal? ManifestKilos { get; set; }
        public decimal? VolumeWeight { get; set; }
        public decimal? Capacity { get; set; }
        public string Registration { get; set; }
        public string FWTruckRoute { get; set; }
        public int? EmployeeID { get; set; }
        public decimal? VolumeCapacity { get; set; }
        public decimal? MassCapacity { get; set; }
        public DateTime? DepartureDateTime1 { get; set; }
        public DateTime? ArrivalDateTime1 { get; set; }
        public DateTime? DepartureDateTime2 { get; set; }
        public DateTime? ArrivalDateTime2 { get; set; }
        public DateTime? ExpectedDepartureTime1 { get; set; }
        public DateTime? ExpectedDepartureTime2 { get; set; }
        public string Routes { get; set; }
        public string FromBranch { get; set; }
        public int? FromBranchID { get; set; }
        public string ToBranch { get; set; }
        public int? ToBranchID { get; set; }
        public int? TotalParcels { get; set; }
        public string SecondVariance { get; set; }
        public string TimeVariance { get; set; }
        public int? ImageCount { get; set; }
        public string Truck { get; set; }
        public string RouteCreatedBy { get; set; }
        public string UploadedByAdmin { get; set; }
        public int? CCLRouteID { get; set; }
        public decimal? VisualCapacity { get; set; }
        public DateTime? Duration { get; set; }
        public string URL { get; set; }
        public long? SupplierID { get; set; }
        public int? CCLID { get; set; }
        public int? PurchaseOrderID { get; set; }
        public decimal? AggregatedVehicleCapacity { get; set; }
        public decimal? ChargeMass { get; set; }
        public int? Waybills { get; set; }
        public int? TotalQty { get; set; }
        public decimal? TritonEstimatedChargeMass { get; set; }
        public decimal? RevisedCapacity { get; set; }
        public decimal? FreightWareCapacity { get; set; }
        public string Remarks { get; set; }
        public decimal? EstimatedChargeMass { get; set; }
        public string SupplierName { get; set; }
        public int? ManifestedQty { get; set; }
        public string DepartureVehicle { get; set; }
        public long? LookUpCodeID { get; set; }
        public int? TotalVehicleCapacity { get; set; }
        public int? VehicleID { get; set; }
        public int? Trailer1VehicleID { get; set; }
        public int? Trailer2VehicleID { get; set; }
        public string VehicleRegistration { get; set; }
        public string Trailer1Registration { get; set; }
        public string Trailer2Registration { get; set; }
        public int? isTritonVehicle { get; set; }
        public string VehicleType { get; set; }
        public int? VehicleCapacity { get; set; }
        public string VehicleClass { get; set; }
        public string Trailer1VehicleType { get; set; }
        public int? Trailer1Capacity { get; set; }
        public string Trailer1VehicleClass { get; set; }
        public string Trailer2VehicleType { get; set; }
        public int? Trailer2Capacity { get; set; }
        public string Trailer2VehicleClass { get; set; }
        public decimal? MonthlyRate { get; set; }
        public int? CountOfManifests { get; set; }
        public decimal? AggregatedMonthlyRate { get; set; }
        public decimal? TritonVolume { get; set; }
        public decimal? TritonChargeMass { get; set; }
        public decimal? TotalVolume { get; set; }
        public decimal? FreightValue { get; set; }
    }
}
