using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblMasterReasons")]
    public class tblMasterReasons
    {

        
        [Dapper.Contrib.Extensions.Key]
        public  int ReasonID { get; set; }
        
        [Required]
        public  int PurchaseOrderTypeID { get; set; }
  
        [Required]
        public  string Reason { get; set; }
      
        [Required]
        public  int Status { get; set;  }
        
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public  DateTime StatusDate { get; set; }
      



    }
}
