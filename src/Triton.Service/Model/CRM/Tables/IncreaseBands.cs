using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("IncreaseBands")]
    public class IncreaseBands
    {
        [Key]
        public int IncreaseBandID { get; set; }
        public int? IncreaseID { get; set; }
        public DateTime IncreaseDate { get; set; }
        public  int? MinAmount { get; set; }
        public int? MaxAmount { get; set; }
        public bool LessThan { get; set; }
        public bool GreaterThan { get; set; }
        public int? DestinationRateClass { get; set; }
        public bool MoveUp { get; set; }
        public bool Uniques { get; set; }
        public int? UniqueOffSet { get; set; }
        public bool PosOffset { get; set; }
        public decimal StandardIncrease { get; set; }
        public bool Standard { get; set; }
    }
}
