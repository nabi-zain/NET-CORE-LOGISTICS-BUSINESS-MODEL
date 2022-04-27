using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class EditTripDeliverySiteMapsModel
    {
        public TripDeliverySiteMaps TripDeliverySiteMaps { get; set; }

        public TripNames TripNames { get; set; }

        public CustomerUniqueRates CustomerUniqueRates { get; set; }

        public int FromSiteID { get; set; }

        public int ToSiteID { get; set; }

        public Sites FromSite { get; set; }

        public Sites ToSite { get; set; }

        public List<TripLegVehicle> TripLegVehicle { get; set; }

        public string SelectedTrailer { get; set; }

        public int? SelectedVehicleID { get; set; }

        public int? SelectedEmployeeID { get; set; }

        public LookUpCodes TrailerTypeList { get; set; }

        public int? SelectedSupplierID { get; set; }

        public decimal? SubbyCost { get; set; }

        public bool SubbyChecked { get; set; }

        public string PONumber { get; set; }

        public int? PurchaseOrderID { get; set; }

        public decimal? TotalExVat { get; set; }


        //public List<TripLegDepartureTime> TripLegDepartureTime { get; set; }

        //public List<TripLegConsumption> TripLegConsumption { get; set; }
    }
}
