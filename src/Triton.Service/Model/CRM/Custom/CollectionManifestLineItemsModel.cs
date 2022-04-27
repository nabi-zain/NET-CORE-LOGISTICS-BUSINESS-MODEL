using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;

namespace Triton.Model.CRM.Custom
{
    public class CollectionManifestLineItemsModel
    {
        public CollectionManifestLineItems CollectionManifestLineItems { get; set; }
        public CollectionManifests CollectionManifests { get; set; }
        public CollectionManifestStatuss CollectionManifestStatuss { get; set; }
        public CollectionRequests CollectionRequests { get; set; }

    }
}
