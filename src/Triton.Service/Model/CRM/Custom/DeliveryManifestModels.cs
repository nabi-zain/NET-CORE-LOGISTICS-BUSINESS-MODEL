using System;
using System.Collections.Generic;
using  Triton.Model.CRM.Tables;
using  Triton.Model.TritonVehicles.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class DeliveryManifestModels
    {
        public DeliveryManifests DeliveryManifest { get; set; }
        public DeliveryManifestStatuss DeliveryManifestStatus { get; set; }
        public RouteNames Route { get; set; }
        public SubContractors Subcontractor  { get; set; }
        public Vehicles  Vehicle { get; set; }
    }

    public class DeliveryManifestSearchModels
    {
        public List<DeliveryManifestModels> Deliveries { get; set; }
        public List<RouteNames> Routes { get; set; }

        public DateTime?  SelectedDate { get; set; }
        public int? SelectedRouteID { get; set; }
    }

    public class DeviceDeliveryManifest
    {
        public long DeliveryManifestID { get; set; }
        public string DeliveryRoute { get; set; }
        public string DeliveryVehicleRegistration { get; set; }
        public string DelManifestNumber { get; set; }
        public int TotalQty { get; set; }
    }
}
