using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerUniqueRateBands")]
    public class CustomerUniqueRateBands
    {
        [Key]
        public int CustomerUniqueRateBandID { get; set; }
        public int CustomerUniquesRateID { get; set; }
        public int BandOrder { get; set; }
        public decimal QtyFrom { get; set; }

        public decimal QtyTo { get; set; }
        public decimal Rate { get; set; }

    }
}
