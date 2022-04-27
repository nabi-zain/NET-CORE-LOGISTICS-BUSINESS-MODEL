using System;

namespace Triton.Model.TritonLH.Custom
{
    public class DeliveriesJava
    {
        public long DeliveryID { get; set; }
        public string FromToSite { get; set; }

        public string ToSiteCustomerName { get; set; }
        public string FromSiteCustomerName { get; set; }

        public DateTime ScheduledDate { get; set; }

        public long Tonnage { get; set; }
    }
}
