using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.StoredProcs
{
    public class sprc_DailySales_Dashboard_Graphs_All_Avg
    {
        public Decimal Sales { get; set; }
        public Decimal Budget { get; set; }
        public Decimal Target { get; set; }
        public Decimal Min { get; set; }
        public Decimal Max { get; set; }
    }
}
