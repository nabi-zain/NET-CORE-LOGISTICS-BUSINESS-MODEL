using System.ComponentModel;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Routes_By_ZoneController_Select
    {
        [DisplayName("Route")]
        public string DeliveryRoute { get; set; }

        [DisplayName("Route Name")]
        public string RouteName { get; set; }

        [DisplayName("Zone Controller")]
        public string ZoneController { get; set; }

        [DisplayName("Deliveries")]
        public int? Deliveries { get; set; }

        [DisplayName("OS")]
        public int? OS { get; set; }

        [DisplayName("Due Today")]
        public int? DueToday { get; set; }

        [DisplayName("OS Due Today")]
        public int? OSDueToday { get; set; }

        [DisplayName("Due 1 HR")]
        public int? DueIn1HR { get; set; }

        [DisplayName("Overdue")]
        public int? Overdue { get; set; }

        [DisplayName("Previously Delivered")]
        public int? PreviouslyDelivered { get; set; }

        [DisplayName("Delivered")]
        public int? Delivered { get; set; }

        [DisplayName("Failed")]
        public int? Failed { get; set; }

        [DisplayName("Mobile Status")]
        public string MobileStatus { get; set; }

        [DisplayName("FMO Route Name")]
        public string FMORouteName { get; set; }

        [DisplayName("Route")]
        public string RouteDropDownList {
            get 
            {
                return DeliveryRoute + " - " + RouteName;
            }
        }
    }
}