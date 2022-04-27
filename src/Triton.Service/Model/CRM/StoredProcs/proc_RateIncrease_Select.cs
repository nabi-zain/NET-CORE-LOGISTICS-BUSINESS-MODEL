using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_RateIncrease_Select
    {
        public int RateIncreaseID { get; set; }
        public DateTime RateIncreasePeriod { get; set; }
        public string RateIncreaseString { get; set; }
        public int RateCycleID { get; set; }
        public bool isCompleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public string ShortDescription { get; set; }
    }
}
