using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblSupplierLoadingInstructionModel
    {
      public  tblSupplierLoadingInstruction LoadingInstruction { get; set; }
        public tblPurchaseOrders PurchaseOrder { get; set; }
    }
}
