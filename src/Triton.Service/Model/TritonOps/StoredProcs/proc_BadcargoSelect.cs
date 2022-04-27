using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.LeaveManagement.Tables;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_BadcargoSelect
    {
        public int BadcargoID { get; set; }

        public int CategoryID { get; set; }
        public int CustomerID { get; set; }
        public int BranchID { get; set; }
        public string WaybillNo { get; set; }
        public string Volume { get; set; }
        public decimal TotalMass { get; set; }
        public string Comments { get; set; }
        public DateTime DateSaved { get; set; }
        public int UserID { get; set; }
        public Byte Saved { get; set; }
        public byte[] FileData { get; set; }
    }
}
