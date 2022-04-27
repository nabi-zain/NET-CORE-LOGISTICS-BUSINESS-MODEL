using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
   public class tblMessageModels
    {
       public tblMessage Message { get; set; }
       public tblPurchaseOrders PurchaseOrder { get; set; }
       public tblMessage RelatedMessage { get; set; }
       public tblMessage ParentMessage { get; set;}
       public tblUsers Creator { get; set; }


    }
}
