using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.Custom
{
    public class BranchUserDepartmentsModel
    {
        public Users User { get; set; }
        public List<Branches> Branches { get; set; }
        public List<Departments> Departments { get; set; }
    }
}
