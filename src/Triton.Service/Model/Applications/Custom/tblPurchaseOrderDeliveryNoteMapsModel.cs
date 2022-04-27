using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
   public class tblPurchaseOrderDeliveryNoteMapsModel

    {
        public tblPurchaseOrderDeliveryNoteMaps PurchaseOrderDeliveryNoteMap { get; set; }
        public tblPurchaseOrders PurchaseOrder { get; set; }
  
    }
}
