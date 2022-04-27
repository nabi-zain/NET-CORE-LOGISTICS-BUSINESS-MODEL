using Triton.Model.HelpDesk.Tables;
using Triton.Model.TritonSecurity.Tables;
using Roles = Triton.Model.TritonGroup.Tables.Roles;
using Users = Triton.Model.TritonGroup.Tables.Users;

namespace Triton.Model.HelpDesk.Custom
{
    public class UserRoleBranchDepartmentMapsModel
    {
        public UserRoleBranchDepartmentMaps UserRoleBranchDepartmentMaps { get; set; }
        //Users from tritonGroup
        public Users Users { get; set; }
        public Branches Branches { get; set; }
        public Departments Departments { get; set; }
        public Categorys Categorys { get; set; }
        public Roles  Roles { get; set; }

    }
}
