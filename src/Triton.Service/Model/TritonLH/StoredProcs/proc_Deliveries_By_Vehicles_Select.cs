using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.StoredProcs
{
    public class proc_Deliveries_By_Vehicles_Select
    {
        public int VehicleID { get; set; }
        public string Registration { get; set; }
        public string VehicleType { get; set; }
        public DateTime ScheduledDate { get; set; }
        public int Scheduled { get; set; }
        public int DeliveryID { get; set; }
    }
}
