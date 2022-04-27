using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblMasterSupplierModels
    {
        public tblMasterSuppliers Supplier { get; set;}
        public tblMasterGLCodes GLCode { get; set; }
        public tblSupplierTypes SupplierType { get; set; }
        public tblAdminGroup AdminGroup { get; set; }
        public Companys Company { get; set; }

        public tblSupplierPaymentTypes PaymentType { get; set; }
        public tblStatus Status { get; set; }
        public tblSupplierTerms SupplierTerms { get; set; }
        public tblCountry Country { get; set; }


    }
}
