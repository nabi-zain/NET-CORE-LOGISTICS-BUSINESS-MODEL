using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.CRM.Custom
{
    public class CompanySystemMapModel
    {
        public CompanySystemMaps CompanySystemMaps { get; set; }
        public Companys Companys { get; set; }
        public Systems Systems { get; set; }
        
    }

    public class CompanySystemMapEditModel
    {
        public CompanySystemMapModel CompanySystemMapModel { get; set; }
        public List<CompanySystemMaps> CompanySystemMapses { get; set; }
        public List<Companys> Companyses { get; set; }
        public List<Systems> Systemses { get; set; }
    }
}
