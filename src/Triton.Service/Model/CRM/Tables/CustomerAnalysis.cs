using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerAnalysis")]
    public class CustomerAnalysis
    {
        [Key]
        public int CustomerAnalysisID { get; set; }
        public int CustomerID { get; set; }
        public DateTime? IncreaseDate { get; set; }
        public bool ProcessCompleted { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Ref { get; set; }
        public bool HasOpsNote { get; set; }
        public string OpsNote { get; set; }
        public int? RateIncreaseID { get; set; }
        public bool isManual { get; set; }
        public int? FinalStageID { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string OutCome { get; set; }
        public bool ExcludeFromReview { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
