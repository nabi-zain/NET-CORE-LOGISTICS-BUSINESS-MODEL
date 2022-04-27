using System;
using System.ComponentModel;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Deliveries_By_SubContractorRequests_Select
    {
        //[DisplayName("No")]
        public int DeliveryID { get; set; }
        [DisplayName("Scheduled Date")]
        public DateTime ScheduledDate { get; set; }
        [DisplayName("Customer")]
        public string CustomerName { get; set; }
        public string LeaveDisplayName { get; set; }
        [DisplayName("From Site")]
        public string FromSiteCustomerName { get; set; }
        [DisplayName("To Site")]
        public string ToSiteCustomerName { get; set; }
        public int VehicleID { get; set; }
        public int Trailer1VehicleID { get; set; }
        public int Trailer2VehicleID { get; set; }
        public int LookupcodeID { get; set; }
    }
}
