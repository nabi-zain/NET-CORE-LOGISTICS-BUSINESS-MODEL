using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Custom;

namespace Triton.Model.TritonInternalOrders.Custom
{
    public class ProcurementModel
    {
        public long ItemTypeLookupID { get; set; }
        public long SizeLookupID { get; set; }
        public long TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int BranchID { get; set; }

        [DisplayName("Branch")]
        [Write(false)]
        [Computed]
        public string BranchFullName { get; set; }
        [DisplayName("Item")]
        [Write(false)]
        [Computed]
        public string Item { get; set; }

        [DisplayName("Size")]
        [Write(false)]
        [Computed]
        public string Size { get; set; }

    }
}
