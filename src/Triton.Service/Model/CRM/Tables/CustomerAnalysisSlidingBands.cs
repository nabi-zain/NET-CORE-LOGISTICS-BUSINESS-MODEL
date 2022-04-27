using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerAnalysisSlidingBands")]
    public class CustomerAnalysisSlidingBands
    {
        public int CustomerAnalysisSlidingBandID { get; set; }
        public int CustomerAnalysisID { get; set; }
        public decimal QtyFrom { get; set; }
        public decimal QtyTo { get; set; }
        public int ServiceID { get; set; }
    }
}
