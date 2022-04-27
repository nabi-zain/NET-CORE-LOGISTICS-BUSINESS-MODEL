using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{

    [Table("PartReason")]
    public class PartReason
    {
        [Key]
        public int PartReasonID { get; set; }
        public int? BookingsID { get; set; }
        public int? InventoryID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public int? VehicleID { get; set; }
        public int? Quantity { get; set; }
        public bool? Issued { get; set; }
        public decimal? SellingPriceExVAT { get; set; }
        public string Note { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Rate { get; set; }
    }
}
