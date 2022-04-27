using Triton.Model.Applications.Tables;
using Triton.Models.PurchaseOrders.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblSupplierBankDetailModel
    {
        public tblSupplierBankDetails SupplierBankID { get; set; }
        public tblMasterSuppliers Supplier { get; set; }
        public tblMasterBranches BranchCode { get; set; }
      public  tblSupplierBankDetails BankName { get; set; }

    }
}
