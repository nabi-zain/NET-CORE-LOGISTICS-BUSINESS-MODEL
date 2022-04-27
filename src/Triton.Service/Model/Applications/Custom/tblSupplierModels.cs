using System.Collections.Generic;
using Triton.Model.Applications.StoredProcs;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{

    public class tblSupplierModels
    {
       
        public tblMasterSuppliers Supplier {get; set;}
        public tblSupplierTypes SupplierType { get; set; }
        public tblSupplierTerms Terms { get; set; }
            
        public tblBBBEEs BBBEE { get; set; }
        public List<tblSupplierDocumentCategory> DocumentCategories { get; set; }
        public SupplierDocExpiryIDs Documents { get; set; }
    }


    public class SupplierEditModels
    {
        public tblSupplierModels ComplexSupplier { get; set; }
        public List<proc_SupplierBilling> SupplierBilling { get; set; }
    }

public class SupplierDocExpiryIDs
    {
        public int? BBBEEDocID { get; set; }
        public int? LOGSDocID { get; set; }
        public int? GITDocID { get; set; }
    }
}
