using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_DovetailRoutes
    {
        public string Route { get; set; }
        public string RouteName { get; set; }
        [DisplayName("Last Event")]
        public DateTime? LastEvent { get; set; }
        [DisplayName("Scan-FMO")]
        public int? ScannerToFMO { get; set; }
        [DisplayName("FMO-FW")]
        public int? FMOtoFreightware { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        [DisplayName("Scan-FMO AVG")]
        public int? ScannerToFMOAvg { get; set; }
        [DisplayName("FMO-FW AVG")]
        public int? FMOtoFreightwareAvg { get; set; }
        [DisplayName("Scan-FMO MAX")]
        public int? ScannerToFMOMax { get; set; }
        [DisplayName("FMO-FW MAX")]
        public int? FMOtoFreightwareMax { get; set; }
        [DisplayName("Scan-FMO MIN")]
        public int? ScannerToFMOMin { get; set; }
        [DisplayName("FMO-FW Min")]
       public int? FMOtoFreightMin { get; set; }

    }
}
