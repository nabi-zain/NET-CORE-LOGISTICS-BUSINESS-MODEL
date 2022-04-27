using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPurchaseOrderBatchHeaderLink")]
   public class tblPurchaseOrderBatchHeaderLink
    {

        
        [Key]
        public int BatchHeaderLinkID { get; set; }
      
        public int BatchHeaderID { get; set; }


        public int PurchaseOrderID { get; set; }
 
    }
}
