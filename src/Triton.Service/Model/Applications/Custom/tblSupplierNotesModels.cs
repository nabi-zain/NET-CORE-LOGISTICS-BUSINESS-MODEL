
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblSupplierNotesModels
    {
        public tblSupplierNotes Note { get; set; }
        public tblMasterSuppliers Suppliers { get; set; }
      
        public Notifications.Tables.Notification Notification { get; set; }
    }
}
