using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
   public class tblPurchaseOrderAuditModel
    {
        public tblPurchaseOrderAudit Audit { get; set; }

        public tblPurchaseOrders PurchaseOrder { get; set; }

        public tblAuditEventType PurchaseOrderAuditEventType { get; set; }

    }
}
