using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class DeliveriesSubContractorsModels
    {
        public DeliveriesSubContractors DeliveriesSubContractors { get; set; }
        public Deliveries Deliveries { get; set; }
        public DeliveriesPallets DeliveriesPallets { get; set; }
        public DeliveriesSchedules DeliveriesSchedules { get; set; }
        public DeliveriesVehicles DeliveriesVehicles { get; set; }
        public Invoices Invoices { get; set; }
        public DeliveriesLegs DeliveriesLegs { get; set; }
        public TripDelivery TripDelivery { get; set; }
    }
}
