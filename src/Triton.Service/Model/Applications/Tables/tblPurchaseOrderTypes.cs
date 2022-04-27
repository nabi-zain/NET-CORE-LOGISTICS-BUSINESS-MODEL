using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPurchaseOrderTypes")]
    public class tblPurchaseOrderTypes
    {
        
        [Dapper.Contrib.Extensions.Key]
        public  int PurchaseOrderTypeID { get; set; }
    
        [DisplayName("Purchase Order Type")]
        [Required]
        public  string PurchaseOrderType { get; set; }
  
        [Required]
        public  string TypeUrl { get; set; }
        
        [Required]
        [DisplayName("`Can Change To")]
        public  Boolean CanChangeTo { get; set; }
    }
}

