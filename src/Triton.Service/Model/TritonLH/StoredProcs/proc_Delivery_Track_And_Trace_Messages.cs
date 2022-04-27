using System;
using System.Collections.Generic;
using Triton.Model.TritonLH.Views;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Delivery_Track_And_Trace_Messages : vw_Deliveries
    {

        public int SiteContactID { get; set; } // int, not null
        public string CompanyName { get; set; } // varchar(500), not null
        public string ContactName { get; set; } // varchar(500), null
        public string ContactCell { get; set; } // varchar(500), null
        public string ContactSalesRep { get; set; } // varchar(500), null
        public string ContactSalesRepCell { get; set; } // varchar(500), null
        public int SiteID { get; set; } // int, not null
        public int? ARNumber { get; set; } // int, null
        public bool? OnRoute { get; set; } // bit, null
        public bool? OffloadingComplete { get; set; } // bit, null
        public bool? EndCollectionEmailSent { get; set; } // bit, null
        public bool? EndDestinationEmailSent { get; set; } // bit, null
        public DateTime? OnRouteDate { get; set; } // datetime, null
        public DateTime? OffloadingCompleteDate { get; set; } // datetime, null

        public string OnRouteMessageID { get; set; } // uniqueidentifier, null

        public string OffloadingCompleteMessageID { get; set; } // uniqueidentifier, null


    }
}
