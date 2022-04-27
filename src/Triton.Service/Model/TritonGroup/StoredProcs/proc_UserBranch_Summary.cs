using System;

namespace Triton.Service.Model.TritonGroup.StoredProcs
{
    public class proc_UserBranch_Summary
    {
        public int UserBranchID { get; set; }
        public string CreatedBy { get; set; }
        public string BranchFullName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
