using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_CSA_External_Customer_Select
    {
        public int ToBranchID { get; set; }
        public int TotalDeliveries { get; set; }
        public int DueToday { get; set; }
        public int OutStandingDueToday { get; set; }
        public int TotalOutstanding { get; set; }
        public int TotalDelivered { get; set; }
        public int TotalDueInTheNextHour { get; set; }
        public string BranchFullName { get; set; }
        public int CustomerID { get; set; }
        public int PreviouslyDeliveredTotal { get; set; }
        public int LinqGrouping { get; set; }
        public string BranchAlias { get; set; }
        public int TotalDeliveriesOverall { get; set; }
    }
}
