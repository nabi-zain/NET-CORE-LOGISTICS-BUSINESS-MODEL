using System.Collections.Generic;
using Triton.Model.TritonGroup.Tables;

namespace Triton.Model.TritonGroup.ViewModel
{
    public class UserViewModel
    {
        public Users User { get; set; }
        public List<Roles> Role { get; set; }
        public List<UserRoles> UserRole { get; set; }
        public int SelectedRoleId { get; set; }
    }
}
