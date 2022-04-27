using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.TritonGroup.Tables;

namespace Triton.Service.Model.TritonGroup.Custom
{
    public class UserRoleGroupModel
    {
        public List<RoleGroup> RoleGroup { get; set; }
        public UserRoleGroup UserRoleGroup { get; set; }
        public string ErrorMessage { get; set; }
        public int SelectedRoleGroupId { get; set; }
        public Users Users { get; set; }
        
    }
}
