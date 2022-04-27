using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;

namespace Triton.Model.TritonGroup.Custom
{
    public class UserRolesModel
    {
        public Users User { get; set; }
        public Roles Role { get; set; }
        public UserRoles UserRole { get; set; }
    }
}
