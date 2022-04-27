using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class ConsumableReason
    {
        public int ConsumableReasonID { get; set; }
        public int? BookingsID { get; set; }
        public int? InventoryID { get; set; }
        public int? VehicleID { get; set; }
        public decimal? SellingPriceExVAT { get; set; }
        public int? Quantity { get; set; }
    }
}
