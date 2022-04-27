using System.Collections.Generic;
using Triton.Model.CRM.StoredProcs;
using Triton.Service.Model.CRM.StoredProcs;

namespace Triton.Service.Model.CRM.Custom
{
    public class TargetsDashboardModel
    {
        public List<proc_Targets_Dashboard_Select> DashboardModel { get; set; }
        public List<TargetTotal> TargetTotal { get; set; }
        public List<proc_Rep_Customers_Dashboard_Select> CustomerGrid { get; set; }
    }
}
