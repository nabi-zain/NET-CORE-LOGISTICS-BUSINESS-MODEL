using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("DashboardStatistic")]
  public   class DashboardStatistic
    {
        [Key]
        public int id { get; set; }
        public string StatName { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Value { get; set; }
        [Required]
        public string UnitType { get; set; }
        public DateTime DisplayDate { get; set; }
        public string url { get; set; }
        public string Direction { get; set; }
        public int Decimals { get; set; }
        [Required]
        public int PrevValue { get; set; }
        [Required]
        public int preYear { get; set; }
        [Required]
        public int PrevMonth { get; set; }
        [Required]
        public DateTime PrevDisplayDate { get; set; }

    }
}
