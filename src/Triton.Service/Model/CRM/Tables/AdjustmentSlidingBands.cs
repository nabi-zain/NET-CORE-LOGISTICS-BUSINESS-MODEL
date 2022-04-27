
using Dapper.Contrib.Extensions;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Triton.Model.CRM.Tables
{
    [Table("AdjustmentSlidingBands")]
    public class Adjustmentslidingbands
    {
        [Key]
        public int AdjustmentSlidingBandID { get; set; }
        public int AdjustmentID { get; set; }
        public decimal QtyFfrom { get; set; }
        public decimal QtyTo { get; set; }
        public int Rate { get; set; }
        public int ServiceID { get; set; }
    }
}
