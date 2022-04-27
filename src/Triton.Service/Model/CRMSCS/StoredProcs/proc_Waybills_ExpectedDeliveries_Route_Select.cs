namespace Triton.Model.CRMSCS.StoredProcs
{
    public class proc_Waybills_ExpectedDeliveries_Route_Select
    {
        public string DeliveryRoute { get; set; }

        public string RouteName { get; set; }

        public string ZoneController { get; set; }

        public int Deliveries { get; set; }

        public int OS { get; set; }

        public int DueToday { get; set; }

        public int OSDueToday { get; set; }

        public int DueIn1HR { get; set; }

        public int Overdue { get; set; }

        public int PreviouslyDelivered { get; set; }

        public int Delivered { get; set; }

        public int Failed { get; set; }

        public string MobileStatus { get; set; }

        public string FMORouteName { get; set; }
    }
}