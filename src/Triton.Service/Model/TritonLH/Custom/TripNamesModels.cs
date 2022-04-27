using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class TripNamesCreateModel
    {
        public List<Sites> Sites { get; set; }
        public string SelectedSite { get; set; }
        public TripNames TripNames { get; set; }
        public List<TripNameCreatTripLegsModel> TripModelsList { get; set; }
        public string MultipleSiteID { get; set; }
    }


    public class TripNameCreatTripLegsModel
    {
        public TripNames TripName { get; set; }
        public List<TripDeliverySiteMapsModel> TripLegs { get; set; }
    }

    public class TripDeliverySiteMapsModel : TripDeliverySiteMaps
    {
        public string ToSiteCustomerName { get; set; }
        public string FromSiteCustomerName { get; set; }
    }

}