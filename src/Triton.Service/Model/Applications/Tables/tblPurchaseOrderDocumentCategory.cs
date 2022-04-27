using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPurchaseOrderDocumentCategory")]
    public  class tblPurchaseOrderDocumentCategory
    {
        [Key]
        public int PODocumentCategoryID { get; set; }
        [Required]
        public string Descripition { get; set; }

    }
}
