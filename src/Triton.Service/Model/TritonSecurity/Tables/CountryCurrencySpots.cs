using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("CountryCurrencySpots")]
   public class CountryCurrencySpots
    {
        [Dapper.Contrib.Extensions.Key]
        public int CountryCurrencySpotID { get; set; }
        public int CountryID { get; set; }
        public string Rate { get; set; }

    }
}
