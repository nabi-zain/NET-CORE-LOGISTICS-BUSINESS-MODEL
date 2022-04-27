using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Countrys")]
    public class Countrys
    {
        [Dapper.Contrib.Extensions.Key]
        public int CountryID { get; set; }

        [DisplayName("Code")]
        public string Code { get; set; }
        [DisplayName("Country")]
        public string Country { get; set; }

        public string Icon { get; set; }
    }
}
