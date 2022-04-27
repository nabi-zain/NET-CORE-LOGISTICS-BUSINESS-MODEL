using System.Collections.Generic;
using Triton.Model.CRM.StoredProcs;

namespace Triton.Model.CRM.Custom
{
    public class CustomerWaybills_TritonInTouchModel
    {
        public List<proc_CustomerWaybills_TritonInTouch_Dashboard_Select>CustomerWaybillsTritonInTouchDashboardSelect
        {
            get;
            set;
        }
        public TritonInTouchCustomerReport TritonInTouchCustomerReport { get; set; }
        public bool WaybillActivity { get; set; }
    }

    public class TritonInTouchCustomerReport
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public bool IsSelected { get; set; }
    }
}
