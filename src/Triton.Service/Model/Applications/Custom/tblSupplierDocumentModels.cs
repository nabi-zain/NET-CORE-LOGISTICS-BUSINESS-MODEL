using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
   public class tblSupplierDocumentModels

    {
       public tblSupplierDocuments Document { get; set; }
        public tblMasterSuppliers Supplier { get; set; }
        public tblPurchaseOrderDocumentCategory DocumentCategory { get; set; }
    }
}
