using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.CRM.Tables;

namespace Triton.Model.TritonOps.Custom
{
    public class CustomerWaybillTraceAndTrace
    {
        public Waybills Waybills { get; set; }
        public CustomerSiteMaps CustomerSiteMaps { get; set; }
        public Sites Sites { get; set; }
        public RateAreas RateAreas { get; set; }
        public WayBillStatuss WayBillStatuss { get; set; }
        public TransportTypes TransportTypes { get; set; }
        public Customers Customers { get; set; }
        public Deliveries Deliveries { get; set; }
        public DeliveryManifests DeliveryManifests { get; set; }
        public RouteNames RouteNames { get; set; }

    }
}
