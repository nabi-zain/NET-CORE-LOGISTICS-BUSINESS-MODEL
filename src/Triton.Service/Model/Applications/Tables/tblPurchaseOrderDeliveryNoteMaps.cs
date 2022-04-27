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
    [Table("tblPurchaseOrderDeliveryNoteMaps")]
    public class tblPurchaseOrderDeliveryNoteMaps
    {

    
        [Dapper.Contrib.Extensions.Key]
        public  int PurchaseOrderDeliveryNoteMapID { get; set; }

        [Required]
        public  int PurchaseOrderID { get; set; }

        [Required]
        [DisplayName("Delivery Note")]
        public  String DeliveryNoteNo { get; set; }

    }
}
