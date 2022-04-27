using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Locations")]
  public class Locations
    {
        [Key]
        public int LocationID { get; set; }
        public string Description { get; set; }

    }
}
