using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.Applications.Custom
{
 public   class tblSupplierApplicationModel
    {
        public tblSupplierApplication SupplierApplication { set; get; }
        public tblMasterSuppliers Supplier { get; set; }
        public Tables.tblSupplierNotes CreatedBy { get; set; }
        public Tables.tblUsers RequestedBy { get; set; }
        public Branches Branch { get; set; }
        public Tables.tblUsers AllocatedUser { get; set; }
        public tblMasterSuppliers ReplacementSupplier { get; set; }

    }
}
