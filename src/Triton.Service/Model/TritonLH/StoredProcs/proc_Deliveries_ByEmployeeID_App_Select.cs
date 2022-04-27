using System;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Deliveries_ByEmployeeID_App_Select
    {
        public long DeliveryID { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime ScheduledDate { get; set; }
        public string FromSiteCustomerName { get; set; }
        public string FromAddress1 { get; set; }
        public string FromAddress2 { get; set; }
        public string FromAddress3 { get; set; }
        public string FromCity { get; set; }
        public string ToSiteCustomerName { get; set; }
        public string ToAddress1 { get; set; }
        public string ToAddress2 { get; set; }
        public string ToAddress3 { get; set; }
        public string ToCity { get; set; }
        public long? StartODO { get; set; }
        public long? EndODO { get; set; }
        public int? StatusLCID { get; set; }
        public string DeliveryStatus { get; set; }
        public int? CurrentSequece { get; set; }
        public string NextStatus { get; set; }
        public int? VehicleID { get; set; }
        public int? Trailer1VehicleID { get; set; }
        public int? Trailer2VehicleID { get; set; }
        public string VehicleRegistration { get; set; }
        public string Trailer1Registration { get; set; }
        public string Trailer2Registration { get; set; }
        public int TripDeliveryTypeLCID { get; set; }
        public string TripTypeName { get; set; }
        public bool? Locked { get; set; }
    }
}
