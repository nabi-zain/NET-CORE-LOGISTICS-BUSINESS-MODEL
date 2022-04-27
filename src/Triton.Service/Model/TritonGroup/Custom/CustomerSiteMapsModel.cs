using System.Collections.Generic;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.Custom;

namespace Triton.Model.TritonGroup.Custom
{
    public class CustomerSiteMapsModel
    {
        public CustomerSiteMaps CustomerSiteMaps { get; set; }
        public SitesModels Site { get; set; }
        public CustomersModels Customer { get; set; }
    }
        
}
