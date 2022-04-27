using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.StoredProcs
{
    public class sprc_DailySales_Dashboard
    {
        public Decimal Sales { get; set; }
        public Decimal Target { get; set; }
        public Int32 Perc { get; set; }
        public String Branch { get; set; }
        public String Lat { get; set; }
        public String Lng { get; set; }
        public String Color { get; set; }

    }
}
