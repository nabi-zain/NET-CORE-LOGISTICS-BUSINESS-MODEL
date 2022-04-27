using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerDiscounts")]
    public class CustomerDiscounts
    {
        public int CustomerDiscountID { get; set; }
        public int CustomerID { get; set; }
        public decimal Discount { get; set; }
        public int FinancialYear { get; set; }
        public int FinancialMonth { get; set; }
    }
}
