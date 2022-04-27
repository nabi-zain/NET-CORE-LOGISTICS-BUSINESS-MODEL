using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.Custom
{
    public class UserRoleBranchDepartmentMapModel
    {
        public UserRoleBranchDepartmentMap UserRoleBranchDepartmentMap { get; set; }
        public Users User { get; set; }
        public Roles Role { get; set; }
        public Branches Branches { get; set; }
        public Departments Departments { get; set; }
    }
}
