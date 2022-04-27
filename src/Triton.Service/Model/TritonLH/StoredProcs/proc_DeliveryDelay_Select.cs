using System;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_DeliveryDelay_Select
    {
        public int DeliveryDelayID { get; set; }
        public long DeliveryID { get; set; }
        public int DelayLCID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string FromSiteCustomerName { get; set; }
        public string ToSiteCustomerName { get; set; }
        public string Detail { get; set; }
    }
}
