using System.Collections.Generic;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.TritonGroup.Tables;

namespace Triton.Service.Model.TritonGroup.Custom
{
    public class UserBranchModel
    {
        public List<UserBranch> UserBranch { get; set; }
        public Users Users { get; set; }
        public int SelectedBranchID { get; set; }
        public List<Branches> Branches { get; set; }
        public string ErrorMessage { get; set; }
        public string BranchIDS { get; set; }
        public string EditBranchIDS { get; set; }
        public string UserBranchID { get; set; }

    }
}
