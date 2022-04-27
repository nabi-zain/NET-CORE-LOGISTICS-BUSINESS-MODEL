using Triton.Model.CRM.Tables;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.CRM.Tables;

namespace Triton.Service.Model.CRM.Custom
{
    public class CustomerModel
    {
        public Customers Customers { get; set; }
        public Branches Branches { get; set; }
        public CustomerStatuss CustomerStatuss { get; set; }
        public RateClasses RateClasses { get; set; }
        public CustomerAnalysis CustomerAnalysis { get; set; }
        public RateIncreases RateIncreases { get; set; }
    }

    public class CustomerCreditControllerModel
    {
        public Customers Customers { get; set; }
        public Users Users { get; set; }
    }
}
