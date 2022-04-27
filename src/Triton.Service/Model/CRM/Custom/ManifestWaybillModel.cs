using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.CRM.Tables;
using  Triton.Model.TritonSecurity.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class ManifestWaybillModel
    {
        public List<Branches> Branches { get; set; }

        public List<ManifestFW> ManifestFW { get; set; }


        public int SearchFromBranch { get; set; }

        public int SearchToBranch { get; set; }

        public DateTime ManifestDate { get; set; }
    }
}
