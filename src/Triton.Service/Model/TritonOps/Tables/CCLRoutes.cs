using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CCLRoutes")]
    public class CCLRoutes
    {
        [Dapper.Contrib.Extensions.Key]
        public int CCLRouteID { get; set; }

        public string Routes { get; set; }

        public int Kilometers { get; set; }

        [DisplayName("Exp Dep Time")]
        public TimeSpan ExpectedDepartureTime1 { get; set; }

        public TimeSpan ExpectedDepartureTime2 { get; set; }

        public int OriginatingBranchID { get; set; }

        public int TotalVehicles { get; set; }

        public int RouteLookupCodeID { get; set; }

        public decimal? TargetConsumption { get; set; }

        public decimal? Rate { get; set; }

        public bool? isDepartingNextDay { get; set; }

        public bool Active { get; set; }

        [DisplayName("Transit Time")]
        public TimeSpan TransitTime { get; set; }

        public bool? ExcludeCompliance { get; set; }

        public bool? BaseRateNotRequired { get; set; }

        public int? DebriefLookUpCodeID { get; set; }
    }
}