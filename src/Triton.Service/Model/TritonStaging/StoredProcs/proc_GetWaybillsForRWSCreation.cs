using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonStaging.StoredProcs
{

    public class RWSParcels
    {
        public long ParcelID { get; set; }
        public int ParcelNo { get; set; }
        public string tracking_no { get; set; }
        public int Qty { get; set; }
        public decimal PLength { get; set; }
        public decimal PBreadth { get; set; }
        public decimal PHeight { get; set; }
        public decimal PMass { get; set; }
    }

    public class proc_GetWaybillsForRWSCreation
    {
        public long WaybillID { get; set; }
        public string WaybillNo { get; set; }
        public string job_type { get; set; }
        public int ItemQty { get; set; }
        public decimal ItemMass { get; set; }
        public string delivery_name { get; set; }
        public string delivery_email { get; set; }
        public string delivery_phone { get; set; }
        public string delivery_company { get; set; }
        public string delivery_building { get; set; }
        public string delivery_street { get; set; }
        public string delivery_suburb { get; set; }
        public string delivery_town { get; set; }
        public string delivery_postal_code { get; set; }
        public List<RWSParcels> ParcelArray { get; set; }

    }
}
