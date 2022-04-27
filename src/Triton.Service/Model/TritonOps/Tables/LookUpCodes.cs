using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    public class LookUpCodes
    {
        [ScaffoldColumn(false)]
        [Required]
        public long LookUpCodeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Descriptions { get; set; }

        [Required]
        public string Groups { get; set; }

        [Required]
        public int Sequence { get; set; }
    }
}
