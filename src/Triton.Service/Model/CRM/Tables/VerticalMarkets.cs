using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("VerticalMarkets")]
    public class VerticalMarkets
    {
        [Key]
        public int VerticalMarketID { get; set; }
        public string Description { get; set; }
    }
}
