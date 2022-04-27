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
    [Table("tblPurchaseOrderDocument")]
    public class tblPurchaseOrderDocument
    {

        [Dapper.Contrib.Extensions.Key]
        public int DocumentID { get; set; }
  

        [Required]
        public int PurchaseOrderID { get; set; }

        [Required]
        public string ImgName { get; set; }
     


        [Required]
        public Byte[] ImgData { get; set; }
      


        [Required]
        public string ImgContentType { get; set; }
        [Required]
        public string ImgLength { get; set; }
   

        [Required]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime DateUploaded { get; set; }

        [Required]
        [DisplayName("PO Document")]
        public int PODocumentCategoryID { get; set; }

  
 
    }
}
