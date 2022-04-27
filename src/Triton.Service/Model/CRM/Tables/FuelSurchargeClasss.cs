using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("FuelSurchargeClasss")]
    public class FuelSurchargeClasss
    {
        [Key]
        public int FuelSurchargeClassID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? CurrentValue { get; set; }
        public decimal? MinumumValue { get; set; }
        public int? IntegerCents { get; set; }
        public decimal? IntegerPerc { get; set; }
    }
}
