using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Applications.Tables
{
   public class tblBranchSuppliers
    {
        [Key]
        public int SupplierBranchID { get; set; }
        public int SupplierID { get; set; }
        public int BranchID { get; set; }
    }
}
