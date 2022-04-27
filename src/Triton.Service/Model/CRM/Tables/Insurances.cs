using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("Insurances")]
    public class Insurances
    {
        [Key]
        public int InsuranceID { get; set; }
        public string InsuranceTypes { get; set; }
        public decimal Premuim { get; set; }
        public decimal Limit { get; set; }
        public int Excess { get; set; }
        public decimal Minumum { get; set; }
        public bool Active { get; set; }
        public bool Auto { get; set; }
        public  bool? NextIncrease { get; set; }
    }
}
