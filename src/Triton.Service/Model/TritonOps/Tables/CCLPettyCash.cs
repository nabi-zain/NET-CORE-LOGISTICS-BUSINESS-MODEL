using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CCLPettyCash")]
    public class CCLPettyCash
    {
        [ScaffoldColumn(false)]
        [Required]
        [Dapper.Contrib.Extensions.Key]
        public int CCLPettyCashID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public long CCLID { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "{0} must be a Number.")]
        public decimal Amount { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public int CreatedByUserID { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
