using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("RateDirections")]
    public class RateDirections
    {
        [Key]
        public int RateDirectionID { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
    }
}
