using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerExistingBusinessTargets")]
    public class CustomerExistingBusinessTargets
    {
        public int CustomerExistingBusinessTargetID { get; set; }
        public int CustomerID { get; set; }
        public int FinancialYear { get; set; }
        public int FinancialMonth { get; set; }
        public decimal Target { get; set; }
    }
}
