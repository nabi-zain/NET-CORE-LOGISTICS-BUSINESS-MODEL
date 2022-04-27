using System.Collections.Generic;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.TritonOps.StoredProcs;

namespace Triton.Model.CRM.Custom
{
    public class CSADashboardModel
    {
        public List<proc_Waybills_CSA_Dashboard_Select> CustomerDeliveryList { get; set; }
        public proc_CSA_Customer_Select DeliveryStatusCount { get; set; }
        public List<WaybillQueryMaster_Waybills_Model> WaybillQueryList { get; set; }
        public int TotalSubCategories { get; set; }
        public string CustomerNameChart { get; set; }
        public string CustomerDeliveredChart { get; set; }
        public string CustomerOutstandingChart { get; set; }
    }
}
