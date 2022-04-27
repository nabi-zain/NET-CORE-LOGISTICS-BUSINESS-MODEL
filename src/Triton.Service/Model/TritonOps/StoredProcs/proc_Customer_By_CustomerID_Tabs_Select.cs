using System;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_Customer_By_CustomerID_Tabs_Select
    {
        public long WaybillID { get; set; } // bigint, not null
        public string WaybillNo { get; set; } // varchar(50), null
        public string AccountCode { get; set; } // varchar(50), null
        public string CustomerName { get; set; } // varchar(200), null
        public string FromRateArea { get; set; } // varchar(50), null
        public string ToRateArea { get; set; } // varchar(50), null
        public string ServiceLevel { get; set; } // nchar(10), null
        public string ROUTE { get; set; } // nvarchar(255), null
        public string RouteName { get; set; } // nvarchar(255), null
        public string ShortDesc { get; set; } // varchar(50), null
        public DateTime? WaybillDate { get; set; } // datetime, null
        public DateTime? DelExpectedDateTimeStamp { get; set; } // datetime, null
        public string SiteCustomerName { get; set; } // varchar(500), null
        public string Comment { get; set; } // nvarchar(max), null
        public DateTime? PODDateTimeStamp { get; set; } // datetime, null
        public string FWCurrentBranch { get; set; } // varchar(5), null
        public string NoteComment { get; set; }
        public string Address4 { get; set; }
        public string ZoneController { get; set; }
        public int DaysLate { get; set; }
        public string DeliveryNo { get; set; }
        public int WaybillStatusID { get; set; }
    }
}

