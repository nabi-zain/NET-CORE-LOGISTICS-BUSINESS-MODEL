using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonOps.Tables
{
    [Table("ChecklistCategories")]
    public class ChecklistCategories
    {
        [Dapper.Contrib.Extensions.Key]
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public int CreatedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? DeletedOn { get; set; }
    }
}
