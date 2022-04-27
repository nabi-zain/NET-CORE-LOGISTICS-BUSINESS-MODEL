using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CountryCurrencyTargets")]
    public class CountryCurrencyTargets
    {
        [Key]
        public int CountryCurrencyTargetID { get; set; }
        public int CountryID { get; set; }
        public decimal Amount { get; set; }
        public int CalMonth { get; set; }
        public int CalYear { get; set; }
        public decimal AmountExFreight { get; set; }
        public decimal AmountNewFreight { get; set; }
        public decimal AmountTransFreight { get; set; }
        public decimal? AmountInclFuel { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
