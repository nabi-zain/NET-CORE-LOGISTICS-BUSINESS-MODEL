using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("Inventory")]
    public class Inventory
    {
        [Key]
        public int InventoryID { get; set; }
        public string ItemNumber { get; set; }
        public string Description { get; set; }
        public string PickingSequence { get; set; }
        public int CategoryLCID { get; set; }
        public int BranchID { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public int DeletedBy { get; set; }
    }
}
