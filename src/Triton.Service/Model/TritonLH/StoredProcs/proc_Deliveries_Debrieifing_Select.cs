using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Deliveries_Debrieifing_Select
    {
        [DisplayName("ID")]
        public long DeliveryID { get; set; }

        [DisplayName("Date")]
        public DateTime ScheduledDate { get; set; }

        [DisplayName("CustomerID")]
        public int CustomerID { get; set; }

        [DisplayName("FromSiteID")]
        public int FromSiteID { get; set; }

        [DisplayName("ToSiteID")]
        public int ToSiteID { get; set; }

        [DisplayName("Name")]
        public string LeaveDisplayName { get; set; }

        [DisplayName("Supplier Name")]
        public string SupplierName { get; set; }

        [DisplayName("From Customer")]
        public string FromSiteCustomerName { get; set; }

        [DisplayName("To Customer")]
        public string ToSiteCustomerName { get; set; }

        [DisplayName("Del No")]
        public string DeliveryNoteNo { get; set; }

        [DisplayName("Dep Date")]
        public DateTime? ActualDepartureDateTime { get; set; }

        [DisplayName("ArrDate")]
        public DateTime? ActualArrivalDateTime { get; set; }

        [DisplayName("Start ODO")]
        public long? StartODO { get; set; }

        [DisplayName("End ODO")]
        public long? EndODO { get; set; }

        [DisplayName("Fuel (L)")]
        public decimal? ActualFuelLitre { get; set; }

        [DisplayName("Fuel Value")]
        public decimal? FuelValue { get; set; }

        [DisplayName("Trip Fuel")]
        public decimal? TripFuel { get; set; }

        [DisplayName("Cust Ord No")]
        public string CustomerOrderNo { get; set; }

        //public bool? DeliveryNoteDoc { get; set; }
        //public bool? ClientDeliveryNote { get; set; }
        //public bool? LoadCon { get; set; }
        //public string Docs { get; set; }
        public string CHEPNo { get; set; }

        public int CustomerSiteMapID { get; set; }

        public string RequiredDocs { get; set; }

        public bool IsTritonVehicle { get; set; }

        public int TarrifTypeLCID { get; set; }
        public int TripDeliveryTypeLCID { get; set; }
    }
}
