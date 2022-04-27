using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonSecurity.Tables;
using LookUpCodes = Triton.Model.TritonGroup.Tables.LookUpCodes;

namespace Triton.Model.TritonSecurity.Custom
{
    public class CollectionManifestsModel
    {
        public CollectionManifests CollectionManifests { get; set; }
        public CollectionManifestStatuss CollectionManifestStatuss { get; set; }
        public SubContractors SubContractors { get; set; }
        public Branches Branches { get; set; }
        public LookUpCodes LookUpCodes { get; set; }
    }
}
