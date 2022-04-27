using System;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_Waybills_Grid_Select
    {
        public int WaybillID { get; set; }
        public string WaybillNo { get; set; }
        public string AccountCode { get; set; }
        public string CustomerName { get; set; }
        public string FromRateArea { get; set; }
        public string ToRateArea { get; set; }
        public string ServiceLevel { get; set; }
        public string ROUTE { get; set; }
        public string RouteName { get; set; }
        public string ShortDesc { get; set; }
        public DateTime WaybillDate { get; set; }
        public DateTime DelExpectedDateTimeStamp { get; set; }
        public string SiteCustomerNAme { get; set; }
        public DateTime PODDateTimeStame { get; set; }
        public string FWCurrentBranch { get; set; }
        public string Comment { get; set; }
    }
}
