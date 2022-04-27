using System;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_CCLRoutings_Email_Select
    {
        public DateTime RouteDate { get; set; } // datetime, not null
        public string DisplayName { get; set; } // varchar(101), null
        public string Alias { get; set; } // nvarchar(50), null
        public string SubContractorNo { get; set; } // varchar(20), null
        public string LinehaulManifestNo { get; set; } // varchar(50), null
        public int? TotalWaybills { get; set; } // int, null
        public decimal? ManifestKilos { get; set; } // decimal(18,2), null
        public decimal? VolumeWeight { get; set; } // decimal(18,2), null
        public int Capacity { get; set; } // int, not null
        public string Registration { get; set; } // varchar(50), not null
        public string FWTruckRoute { get; set; } // varchar(50), null
        public int? VehicleID { get; set; } // int, null
        public int? EmployeeID { get; set; } // int, null

        public decimal? VolumeCapacity { get; set; } // decimal(10,2), null
        public decimal? MassCapacity { get; set; } // decimal(10,2), null

        public DateTime? DepartureDateTime1 { get; set; } // datetime, null
        public DateTime? ArrivalDateTime1 { get; set; } // datetime, null
        public DateTime? DepartureDateTime2 { get; set; } // datetime, null
        public DateTime? ArrivalDateTime2 { get; set; } // datetime, null
        public TimeSpan? ExpectedDepartureTime1 { get; set; } // time(7), null
        public TimeSpan? ExpectedDepartureTime2 { get; set; } // time(7), null
        public string Routes { get; set; } // varchar(50), null
        public string FromBranch { get; set; } // varchar(150), null
        public string ToBranch { get; set; } // varchar(150), null
        public int? TotalParcels { get; set; } // int, null
        public int SecondVariance { get; set; } // int, not null
        public string TimeVariance { get; set; } // varchar(62), not null
        public string Comment { get; set; } // varchar(8000), null
    }
}
