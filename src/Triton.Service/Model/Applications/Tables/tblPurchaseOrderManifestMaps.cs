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
    [Table("tblPurchaseOrderManifestMaps")]
   public  class tblPurchaseOrderManifestMaps
    {
       
        [Dapper.Contrib.Extensions.Key]
        public  int PurchaseOrderManifestMapID { get; set; }

        [Required]
        [DisplayName("PUrchase Order")]
        public  int PurchaseOrderID { get; set; }

        [Required]
        public  String ManifestNo { get; set; }


    }
}
