using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.CRM.Tables;

namespace  Triton.Model.CRM.Custom
{
   public class CustomerSiteModel
    {
        public Waybills Waybills { get; set; }
        public CustomerSiteMaps CustomerSiteMaps { get; set; }
        public Sites Sites { get; set; }
    }
}
