using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonStaging.StoredProcs
{
    public class proc_GetRWSWaybillsForPODImagePopulation
    {
        public string WaybillNo { get; set; }
        public long WaybillID { get; set; }
        public long WaybillTrackandTraceID { get; set; }
        public string AccountCode { get; set; }
        public string Name { get; set; }
        public string WaybillDate { get; set; }
        public string CustomerXRef { get; set; }
        public string ServiceLevel { get; set; }
        public string FromBranch { get; set; }
        public string ToBranch { get; set; }
    }
}
