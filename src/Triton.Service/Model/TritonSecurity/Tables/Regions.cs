using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Regions")]
   public class Regions
    {
        public int RegionID { get; set; }

        public string Description { get; set; }

    }
}
