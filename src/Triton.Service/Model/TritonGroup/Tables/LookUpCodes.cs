using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("Lookupcodes")]
    public class LookUpCodes
    {
        [Dapper.Contrib.Extensions.Key]
        public long LookUpCodeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Detail { get; set; }
        [Required]
        public int LookupcodeCategoryID { get; set; }
        [Required]
        public int Sequence { get; set; }
        [Required]
        public int CreatedByUserID { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public String FAIconString { get; set; }

        public string AdditionalField1Name { get; set; }
        public string AdditionalField1Value { get; set; }
    }
}
