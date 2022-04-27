using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_GetSiteGPS_Waybill_Tracking
    {
        public int SiteID { get; set; }
        public Int64? WaybillID { get; set; }
        public String Longitude { get; set; }
        public String Latitude { get; set; }
        public String GPSType { get; set; }
        public DateTime Stamp { get; set; }

    }
}
