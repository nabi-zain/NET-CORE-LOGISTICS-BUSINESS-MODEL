using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.CRM.Custom
{
   public  class CollectionRequestsModel
    {  
        public List<proc_CollectionRequests> proc_CollectionRequests { get; set; }
        public CollectionRequests CollectionRequests { get; set; }
        public List<CollectionRequestTrackandTracesModel> CollectionRequestTrackandTracesModel { get; set; }
        public Customers Customers { get; set; }
        public Branches Branches { get; set; }
        public CollectionManifests CollectionManifests { get; set; }
        public string CustomerXRef { get; set; }
        public string CollectionRequestNumber { get; set; }
        public DateTime StartDate { get; set; }  = DateTime.Now.AddDays(-14);
        public DateTime EndDate { get; set; } = DateTime.Now;
        public int customerId { get; set; }
        public List<TransportTypes> TransportTypes { get; set; }
        public List<Customers> AllowedCustomerList { get; set; }
        public string FilterDate { get; set; }
        public bool ShowReport { get; set; }
    }
}
