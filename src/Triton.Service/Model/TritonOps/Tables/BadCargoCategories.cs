using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps.Tables
{
    [Table("BadCargoCategories")]
    public class BadCargoCategories
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]

        public int BadCargoCategoryID { get; set; }
        public string CategoryText { get; set; }
        public DateTime? DateUploaded { get; set; }

    }
}
