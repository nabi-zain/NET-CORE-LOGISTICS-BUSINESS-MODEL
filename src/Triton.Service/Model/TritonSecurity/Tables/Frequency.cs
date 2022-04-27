using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Frequency")]
   public class Frequency

    { 
        [Key]
    public int FrequencyID { get; set; }
        public string Description { get; set; }

    }
}
