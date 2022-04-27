using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    public class Manifests
    {
        public int ManifestID { get; set; }
        public string ManifestNo { get; set; }
        public DateTime ManifestDate { get; set; }
        public string ManifestSubcontractorNo { get; set; }
        public string FWManifestVehicle { get; set; }
        public int VehicleID { get; set; }
    }
}
