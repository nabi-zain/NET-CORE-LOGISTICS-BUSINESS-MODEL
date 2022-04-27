using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.CRM.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class DeliveryManifestLineItemModels
    {
        public DeliveryManifestLineItems LineItem { get; set; }
        public DeliveryManifestLineItemStatuss LineItemStatus { get; set; }
        public DeliveryManifestModels DeliveryManifest { get; set; }
        public TransportTypes ServiceType { get; set; }

        public Waybills Waybill { get; set; }
        public Customers Customer { get; set; }
    }
}
