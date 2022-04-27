using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("LookupCodeCategories")]
    public class LookupCodeCategories
    {
        [Dapper.Contrib.Extensions.Key]
        public long LookUpCodeCategoryID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int CreatedByUserID { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
