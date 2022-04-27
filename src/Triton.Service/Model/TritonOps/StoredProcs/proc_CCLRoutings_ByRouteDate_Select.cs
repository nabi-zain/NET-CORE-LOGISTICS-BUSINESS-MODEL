using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.StoredProcs
{

    public class proc_CCLRoutings_ByRouteDate_Select
    {
        [ScaffoldColumn(false)]
        [Dapper.Contrib.Extensions.Key]
        [Required]
        public long CCLID { get; set; }

        [DisplayName("Emp Code")]
        public string CurrentEmployeeCode { get; set; }

        public string Routes { get; set; }

        [DisplayName("Route Date")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RouteDate { get; set; }

        [DisplayName("Departure 1")]
        public DateTime? DepartureDateTime1 { get; set; }

        [DisplayName("Arrival 1")]
        public DateTime? ArrivalDateTime1 { get; set; }

        [DisplayName("Departure 2")]
        public DateTime? DepartureDateTime2 { get; set; }

        [DisplayName("Arrival 2")]
        public DateTime? ArrivalDateTime2 { get; set; }

        [DisplayName("Doc No")]
        public string SubContractorNo { get; set; }

        [ScaffoldColumn(false)]
        public int? CCLRouteID { get; set; }


        public long? TruckLookUpCodeID { get; set; }

        [ScaffoldColumn(false)]
        public int CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }

        public long? DocumentRepositoryID { get; set; }

        public int? SupplierID { get; set; }

        [ScaffoldColumn(false)]
        public bool? Debriefed { get; set; }

        [ScaffoldColumn(false)]
        public int? DebriefedBy { get; set; }

        public DateTime? DebriefedOn { get; set; }
        public int? TrailerLookUpCodeID { get; set; }
        public long? CCLRouteDailyValidationID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public bool? FTL { get; set; }

        [ScaffoldColumn(false)]
        public int? Trailer1VehicleID { get; set; }

        [ScaffoldColumn(false)]
        public int? Trailer2VehicleID { get; set; }
        public int? VehicleID { get; set; }
        public int? EmployeeID { get; set; }
        public int? PurchaseOrderID { get; set; }
        public decimal? MonthlyRate { get; set; }
        public int? Kilometers { get; set; }
        public string DisplayName { get; set; }
        public string Registration { get; set; }
        public long? LookUpCodeID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public string Groups { get; set; }
        public int Sequence { get; set; }
        public string CCLALias { get; set; }
        public string TelCell { get; set; }
        public string TrailerType { get; set; }
        public string PurchaseOrderRef { get; set; }
    }
}
