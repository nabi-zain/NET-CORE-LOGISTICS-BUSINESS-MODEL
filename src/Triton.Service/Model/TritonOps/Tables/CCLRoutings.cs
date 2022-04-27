using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CCLRoutings")]
    public class CCLRoutings
    {
        [Dapper.Contrib.Extensions.Key]
        public long CCLID { get; set; }

        public string CurrentEmployeeCode { get; set; }

        public string Routes { get; set; }

        [DisplayName("Route Date")]
        [DataType(DataType.Date)]
        public DateTime RouteDate { get; set; }

        [DisplayName("Dep Time 1")]
        public DateTime? DepartureDateTime1 { get; set; }

        [DisplayName("Arr Time 1")]
        public DateTime? ArrivalDateTime1 { get; set; }

        [DisplayName("Dep Time 2")]
        public DateTime? DepartureDateTime2 { get; set; }

        [DisplayName("Arr Time 2")]
        public DateTime? ArrivalDateTime2 { get; set; }

        [DisplayName("Sub Cont No")]
        public string SubContractorNo { get; set; }

        public int? CCLRouteID { get; set; }

        public long? TruckLookUpCodeID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public long? DocumentRepositoryID { get; set; }

        public int? SupplierID { get; set; }

        public bool? Debriefed { get; set; }

        public int? DebriefedBy { get; set; }

        public DateTime? DebriefedOn { get; set; }

        public int? TrailerLookUpCodeID { get; set; }

        public long? CCLRouteDailyValidationID { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? DeletedByUserID { get; set; }

        public bool? FTL { get; set; }

        public int? Trailer1VehicleID { get; set; }

        public int? Trailer2VehicleID { get; set; }

        public int? VehicleID { get; set; }

        public int? EmployeeID { get; set; }

        public int? PurchaseOrderID { get; set; }

        public decimal? MonthlyRate { get; set; }

        public CCLRoutes CCLRoutes { get; set; }
    }
}