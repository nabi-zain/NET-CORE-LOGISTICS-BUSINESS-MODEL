using System.Collections.Generic;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.Custom
{
    public class BranchesModel
    {
        public Branches Branches { get; set; }
        public BranchCategorys BranchCategory { get; set; }
        public Regions Region { get; set; }
        public Locations Location { get; set; }
        public Companys Company { get; set; }
        public BranchTypes BranchesType { get; set; }

    }
    
    public class BranchesEditModel
    {
        public BranchesModel BranchesModel { get; set; }
        public Branches Branches { get; set; }
        public List <Regions> Region { get; set; }
        public List<Locations> Location { get; set; }
        public List <Companys> Company { get; set; }
        public List <BranchTypes> BranchesType { get; set; } 
    }
}
