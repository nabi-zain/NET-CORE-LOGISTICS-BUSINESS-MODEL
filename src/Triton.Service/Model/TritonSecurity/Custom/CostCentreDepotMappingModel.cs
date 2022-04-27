using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
namespace Triton.Model.TritonSecurity.Custom
{
  public  class CostCentreDepotMappingModel
    {
        public CostCentreDepotMapping costCentreDepotMapping { get; set; }
        public CostCentres CostCentres { get; set; }
        public Depots Depots { get; set; }
    }

  public class CostCentreDepotMappingEditModel
  {
      public CostCentreDepotMappingModel CostCentreDepotMappingModel { get; set; }
      public CostCentreDepotMapping CostCentreDepotMapping { get; set; }
      public CostCentres CostCentres { get; set; }
      public Depots Depots { get; set; }
  }
}
