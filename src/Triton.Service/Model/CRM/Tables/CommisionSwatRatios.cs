using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CommisionSwatRatios")]
    public class CommisionSwatRatios
    {
        [Key]
        public int CommisionSwatRatioID { get; set; }
        public decimal SwatFrom { get; set; }
        public decimal SwatTo { get; set; }
        public decimal Ratio { get; set; }

        public decimal ActualPercentage { get; set; }
        public int CommLevel { get; set; }
    }
}
