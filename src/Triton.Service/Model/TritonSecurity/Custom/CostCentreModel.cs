using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
namespace Triton.Model.TritonSecurity.Custom
{
   public class CostCentreModel
    {
        public CostCentres CostCentre { get; set; }
        public Regions Region { get; set; }
        public Locations Location { get; set; }
        public Companys Company { get; set; }
        public Countrys Country { get; set; }
        public BranchCategorys BranchCategory { get; set; }

        public static implicit operator CostCentreModel(List<CostCentreModel> v)
        {
            throw new NotImplementedException();
        }
    }

    public class CostCentreEditModel
    {
        public CostCentreModel CostCentresModel { get; set; }
        public List<Regions> Regions { get; set; }
        public List<Locations> Locations { get; set; }
        public List<Companys>Companys { get; set; }
        public List<Countrys> Countrys { get; set; }
        public List<BranchCategorys> BranchCategorys { get; set; }

    }

    public class CostCentreSearchModel
    {
        public CostCentreModel CostCentresModel { get; set; }
        public List<Regions> Regions { get; set; }
        public List<Locations> Locations { get; set; }
        public List<Companys> Companys { get; set; }
        public List<Countrys> Countrys { get; set; }
        public List<BranchCategorys> BranchCategorys { get; set; }
    }


}
