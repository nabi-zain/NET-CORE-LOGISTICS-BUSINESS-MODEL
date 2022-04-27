using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.Tables;
using Triton.Model.TritonLH.Views;

namespace Triton.Model.TritonLH.Custom
{
    public class DeliveryDelayModel
    {
        public DeliveryDelay DeliveryDelay { get; set; }
        public vw_Deliveries Deliveries { get; set; }
        public LookUpCodes Lookupcodes { get; set; }
    }
}
