using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.CRM.Tables
{
    [Table("RateIncreases")]
    public class RateIncreases 
    {
        [Key]
        public int RateIncreaseID { get; set; }
        [Required]
        public DateTime RateIncreasePeriod { get; set; }
        [Required]
        public string RateIncreaseString { get; set; }
        [Required]
        public int RateCycleID { get; set; }
        [Required]
        public bool isCompleted { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
