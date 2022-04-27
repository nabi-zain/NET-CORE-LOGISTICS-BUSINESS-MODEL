using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblPurchaseOrdersModels
    {
        public tblPurchaseOrders tblPurchaseOrders { get; set; }
        public tblMasterSuppliers tblMasterSuppliers { get; set; }
        public tblPurchaseOrderInvoices tblPurchaseOrderInvoices { get; set; }
    }
}
