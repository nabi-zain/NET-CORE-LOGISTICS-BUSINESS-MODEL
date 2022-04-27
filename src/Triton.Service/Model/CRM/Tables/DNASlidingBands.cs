using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DNASlidingBands")]
    public class DNASlidingBands
    {
        public int DNASlidingBandID { get; set; }
        public int DNAID { get; set; }
        public decimal QtyFrom { get; set; }
        public decimal QtyTo { get; set; }
        public int Rate { get; set; }
        public int ServiceID { get; set; }

    }
}
