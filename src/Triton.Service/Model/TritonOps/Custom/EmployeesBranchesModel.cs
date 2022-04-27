using System.Collections.Generic;

namespace Triton.Model.TritonOps.Custom
{
    public class EmployeesBranchesModel
    {
        public List<EmployeesBranchesModel> EmployeesBrancheList { get; set; }
        public string CurrentEmployeeCode { get; set; }
        public string FullNames { get; set; }
        public string Surname { get; set; }
        public string BranchName { get; set; }

    }
}
