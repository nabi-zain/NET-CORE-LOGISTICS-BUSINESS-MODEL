using System.Collections.Generic;
using Triton.Model.TritonGroup.Tables;
using Roles = Triton.Model.TritonGroup.Tables.Roles;

namespace Triton.Model.TritonGroup.Custom
{
    public class UserWithCustomerModel
    {
        public Users Users { get; set; }

        public UserCustomerMap UserCustomerMap { get; set; }

        public List<UserCustomerMap> GetCustomersByUserID { get; set; }
    }

    public class UserWithRoles
    {
        public Users Users { get; set; }

        public UserRoles UserRoles { get; set; }

        public List<Roles> Roles { get; set; }
    }
}
