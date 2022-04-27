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
    [Table("tblPurchaseOrderBatchHeader")]
    public class tblPurchaseOrderBatchHeader
    {

        

        [Dapper.Contrib.Extensions.Key]
        public  int BatchHeaderID { get; set; }
     

        public  string Description { get; set; }


        [Required]
        public  string Comments { get; set; }

     [DisplayName("File Used For Import")]
        [Required]
    
        public  string FileUsedForImport { get; set; }
     
        [Required]

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public  DateTime CreatedDateTime { get; set; }

        [Required]
        [DisplayName("Created By")]
        public  int CreatedByID { get; set; }
       


        [Required]
        public  string Status { get; set; }

    }
}
