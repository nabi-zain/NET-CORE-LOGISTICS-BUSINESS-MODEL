using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_Route_Productivity_Select
    {
        public int RouteID { get; set; }
        public string  Route { get; set; }

        [DisplayName("Name")]
        public string RouteName { get; set; }

        [DisplayName("Col Mass")]
        public int CollectionTotalMass { get; set; }

        [DisplayName("Col Vol")]
        public int CollectionTotalVolume { get; set; }

        [DisplayName("Col")]
        public int CollectionChargeMass { get; set; }

        [DisplayName("Col Scanned In")]
        public int CollectionsScannedIn { get; set; }

        [DisplayName("Del Mass")]
        public int DeliveryTotalMass { get; set; }

        [DisplayName("Del Vol")]
        public int DeliveryTotalVolume { get; set; }

        [DisplayName("Del")]
        public int DeliveryChargeMass { get; set; }

        public int? VehicleID { get; set; }

        [DisplayName("KM")]
        public int? DurationKM { get; set; }

        [DisplayName("Reg")]
        public string Registration { get; set; }

        [DisplayName("Veh Cap")]
        public int? Capacity { get; set; }

        [DisplayName("Prod %")]
        public int? ProductivityPerc { get; set; }        

        [DisplayName("Route")]
        public string CombinedRouteNames { get { return Route + " - " + RouteName; } }

        [DisplayName("Reg KM")]
        public string CombinedRegDuration { get { return Registration + " - " + DurationKM; } }

        [DisplayName("Del %")]
        public int DeliveryPerc { get; set; }

        [DisplayName("Col %")]
        public int CollectionPerc { get; set; }
    }
}
