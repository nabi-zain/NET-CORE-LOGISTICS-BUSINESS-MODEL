using System;
using System.Collections.Generic;
using System.Text;
using Triton.Service.Model.TritonFleetManagement.Tables;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class PartReasonViewModel
    {
        public List<InventoryCustoModel> InventoryCustoModelList { get; set; }
        public List<PartReason> PartReasons { get; set; }
        public List<InventoryCustoModel> PartReasonsList { get; set; }
        public List<InventoryCustoModel> LabourReasonList { get; set; }
        public List<InventoryCustoModel> ConsumableReasonList { get; set; }
        public List<InventoryCustoModel> TyreReasonList { get; set; }
        public OutworksCommission OutworksCommission { get; set; }
    }

    public class InventoryCustoModel
    {
        public int PartReasonID { get; set; }
        public int BookingsID { get; set; }
        public int InventoryID { get; set; }
        public DateTime DeletedOn { get; set; }
        public int DeletedByUserID { get; set; }
        public int VehicleID { get; set; }
        public int Quantity { get; set; }
        public bool Issued { get; set; }
        public decimal SellingPriceExVAT { get; set; }
        public string Note { get; set; }
        public decimal Hours { get; set; }
        public decimal Rate { get; set; }
        public string ItemNumber { get; set; }
        public string Description { get; set; }
        public string PickingSequence { get; set; }
        public int CategoryLCID { get; set; }
        public int BranchID { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
