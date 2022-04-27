using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerRevisedReps")]
    public class CustomerRevisedReps
    {
        [Key]
        public int CustomerRevisedRepID { get; set; }
        public int CustomerID { get; set; }
        public string RevisedRepCode { get; set; }
        public int FinancalYear { get; set; }
    }
}
