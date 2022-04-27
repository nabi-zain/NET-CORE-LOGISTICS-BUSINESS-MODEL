using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
namespace Triton.Model.TritonSecurity.Custom
{
   public class CompanyCostCentreMappingModel
    {
        public CompanyCostCentreMappingModel CompanyCostCentreMappings { get; set; }
        public Companys Companys { get; set; }
        public CostCentres CostCentres { get; set; }
    }

   public class CompanyCostCentreMappingEditModel
   {

       public CompanyCostCentreMappingModel CompanyCostCentreMappingModel { get; set; }
       public CompanyCostCentreMapping CompanyCostCentreMapping { get; set; }
       public CompanyCostCentreMappingModel CompanyCostCentreMappings { get; set; }
       public Companys Companys { get; set; }
       public CostCentres CostCentres { get; set; }

    }
}
