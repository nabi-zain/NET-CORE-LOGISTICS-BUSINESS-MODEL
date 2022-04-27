using System.Collections.Generic;
using Triton.Model.TritonSecurity.Tables;
using Users = Triton.Model.TritonExpress.Tables.Users;

namespace Triton.Model.TritonExpress.Custom
{
    public class UsersModel
    {
        public Users Users { get; set; }
        public List<Branches> Branches { get; set; }
        public List<Departments> Departments { get; set; }

    }
}
