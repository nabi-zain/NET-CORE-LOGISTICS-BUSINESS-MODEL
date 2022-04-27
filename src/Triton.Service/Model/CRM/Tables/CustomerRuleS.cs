using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerRules")]
    public class CustomerRuleS
    {
        [Key]
        public int CustomerRuleID { get; set; }
        public int CustomerID { get; set; }
        public int Ordero { get; set; }
        public string CustomerRule { get; set; }
    }
}
