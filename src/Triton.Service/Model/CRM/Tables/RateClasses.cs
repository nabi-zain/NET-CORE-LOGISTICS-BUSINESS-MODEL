using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.CRM.Tables
{
    [Table("RateClasses")]
    public class RateClasses
    {
        [Key]
        public int RateClassID { get; set; }
        public string Description { get; set; }
        public int RateCycleID { get; set; }
        public bool Active { get; set; }
        public bool canQuote { get; set; }
        public bool canAdjust { get; set; }
    }
}
