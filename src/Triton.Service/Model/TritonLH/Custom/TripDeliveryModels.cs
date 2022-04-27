using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;
using Triton.Model.TritonLH.Views;

namespace Triton.Model.TritonLH.Custom
{
    public class TripDeliveryEditRatesModel
    {
        public TripDelivery TripDelivery { get; set; }

        public List<Deliveries> Deliveries { get; set; }
    }

    public class TripDeliveryWithTripDeliveryTypeLCID
    {
        public TripDelivery TripDelivery { get; set; }

        public TritonGroup.Tables.LookUpCodes LookUpCodes { get; set; }
    }

    public class TripDeliveryDuplicateInsert
    {
        public long TripDeliveryID { get; set; }

        public int DeliveriesToCreate { get; set; }

        public DateTime ScheduledDate { get; set; }

        public int CreatedByUserID { get; set; }
    }
}
