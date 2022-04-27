using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerAdministrationHistorys")]
    public class CustomerAdministrationHistory
    {
        [Dapper.Contrib.Extensions.Key]
        public int CustomerAdministrationHistoryID { get; set; }
        public int CustomerID { get; set; }
        public int? AssignedRepCodeID { get; set; }
        public string FWRepCode { get; set; }
        public string FWRateCode { get; set; }
        public DateTime? RevAnnDate { get; set; }
        public DateTime? FirstRegrade { get; set; }
        public DateTime? FinalRegrade { get; set; }
        public int? Ceiling { get; set; }
        public DateTime? HistoryDate { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string CommLevel { get; set; }
        public bool? AccBillingOnly { get; set; }
        public int? ShareRepID { get; set; }
        public int? Share { get; set; }
        public int? ShareTarget { get; set; }
        public int? ShareCommTypeID { get; set; }
        public bool? hasFixedPerc { get; set; }
        public decimal? FixedPerc { get; set; }
        public bool isLocked { get; set; }

    }
}
