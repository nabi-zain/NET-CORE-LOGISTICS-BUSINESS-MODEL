using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonStaging.StoredProcs
{
    public class proc_GetWaybillsforRWSPodInfo
    {
        public string WaybillNo { get; set; }
        public long WaybillTrackandTraceID { get; set; }
        public long WaybillID { get; set; }
    }
}
