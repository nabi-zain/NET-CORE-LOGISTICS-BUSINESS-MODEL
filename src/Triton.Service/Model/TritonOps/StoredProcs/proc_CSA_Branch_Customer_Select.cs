using System;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_CSA_Branch_Customer_Select
    {
        public int? ToBranchID { get; set; } // int, null
        public int TotalDeliveries { get; set; } // int, not null
        public int DueToday { get; set; } // int, not null
        public int OutStandingDueToday { get; set; } // int, not null
        public int? TotalOutstanding { get; set; } // int, null
        public int? TotalDelivered { get; set; } // int, null
        public int TotalDueInTheNextHour { get; set; } // int, not null
        public string BranchFullName { get; set; } // varchar(150), null
        public int? CustomerID { get; set; } // int, null
    }
}
