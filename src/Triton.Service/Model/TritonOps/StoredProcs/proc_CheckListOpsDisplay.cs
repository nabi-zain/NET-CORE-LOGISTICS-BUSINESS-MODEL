using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_CheckListOpsDisplay
    {
        public string FullNames { get; set; }
        public string BagNumber { get; set; }
        public string RouteName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string BranchFullName { get; set; }
        public int BranchID { get; set; }
        public int CheckListID { get; set; }

    }

    public class proc_CheckListOpsDisplayModel
    {
        public List<proc_CheckListOpsDisplay> CheckListOpsDisplay { get; set; }
        public List<TritonSecurity.Tables.Branches> Branches { get; set; }
        public int BranchID { get; set; }
    }
    
}
