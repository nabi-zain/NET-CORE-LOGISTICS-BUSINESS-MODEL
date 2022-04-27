using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.Custom
{
    public class BranchAuditModel
    {
        public BranchAudits BranchAudit { get; set; }
        public Branches BranchID { get; set; }

        public Users ContactUserID { get; set; }


    }
}
