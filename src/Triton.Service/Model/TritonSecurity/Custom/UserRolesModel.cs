using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
namespace Triton.Model.TritonSecurity.Custom
{
   public class UserRolesModel
    {
        public UserRoles UserRoles { get; set; }
        public Users Users { get; set; }
        public Roles Roles { get; set; }
        public Companys Companys { get; set; }
        public CostCentres CostCentres { get; set; }
        public Departments Departments { get; set; }

    }
}
