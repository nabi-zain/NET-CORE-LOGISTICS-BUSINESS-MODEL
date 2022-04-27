using Triton.Model.CRM.Tables;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Service.Model.TritonOps.Custom
{
    public class CustomerServiceAgentModel
    {
        public CSA CustomerServiceAgent { get; set; }
        public Customers Customers { get; set; }
        public Users Users { get; set; }
        public Waybills Waybills { get; set; }
    }
}
