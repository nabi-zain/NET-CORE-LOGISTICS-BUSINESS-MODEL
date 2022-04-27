using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("FuelSurcharges")]
    public class FuelSurcharges
    {
        [Key]
        public int FuelSurchargeID { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal SurchargePerc { get; set; }
    }
}
