using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonInternalOrders.Custom
{
    public class OrderTotalCostModel
    {
        public long OrderID { get; set; }
        public long OrderLineItemID { get; set; }
        public long BranchID { get; set; }
        public long ItemTypeLookupID { get; set; }
        public long SizeLookupID { get; set; }
        public decimal TotalCost { get; set; }
    }
}
