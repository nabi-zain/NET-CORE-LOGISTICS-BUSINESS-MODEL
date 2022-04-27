using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.CRM.Tables;
using Triton.Model.HelpDesk.StoredProcs;

namespace  Triton.Model.CRM.Custom
{
   public class CustomerNotificationMapsModel
    {
        public CustomerNotificationMaps CustomerNotificationMaps { get; set; }
        public Customers Customers { get; set; }
        public FWEventCodes FWEventCodes { get; set; }
    
     
    }

    public class CustomerNotificationMapsEditModel
    {
        public CustomerNotificationMaps CustomerNotificationMaps { get; set; }
        public List<Customers> Customers { get; set; }
        public List<FWEventCodes> FWEventCodes { get; set; }
        public int SelectedCustomerId { get; set; }
        public List<proc_CustomerNotificationMapSearch> proc_CustomerNotificationMapsSearch { get; set; }
        public int SelectFwEventCodeID { get;set; }
    }
}
