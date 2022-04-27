using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblPurchaseLineItemModels
    {

       public tblMasterGLCodes GLCode { get; set; }
        public tblLabourTypes LabourType { get; set; }
        public tblLineHaulTypes LineHaulTypes { get; set; }
        public tblPurchaseLineItems LineItem { get; set; }
        public tblPurchaseOrders PurchaseOrder { get; set; }

        public TritonVehicles.Tables.VehicleConfigs VehConfig { get; set; }
        public TritonVehicles.Tables.VehicleExpenseTypes VehExpenseType { get; set; }
        public TritonVehicles.Tables.Vehicles VehHire { get; set; }
        public TritonVehicles.Tables.VehicleTypes VehicleType { get; set; }
        public TritonVehicles.Tables.VehicleTonnage VehTonnage { get; set; }

    }
}
