using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.StoredProcs
{
    public class proc_VendorCodes_String_Agg
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string VendorCodes { get; set; }
        public string CustomerNameVendorCodes { get; set; }
    }
}
