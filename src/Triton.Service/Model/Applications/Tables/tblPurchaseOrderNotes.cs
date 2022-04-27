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
    [Table("tblPurchaseOrderNotes")]
   public class tblPurchaseOrderNotes
    {

        
        [Dapper.Contrib.Extensions.Key]
        public  int NoteID { get; set; }
       
        [DescriptionAttribute("FK_PurchaseOrderID")]

        [Required]
        public  int PurchaseOrderID { get; set; }
       
        [Required]
        public  string Comment { get; set; }
        
        [Required]
   
        
        
        public  tblUsers CreatedByObject { get; set; }
  
   
        [Required]
        [DisplayName("Name")]
        public String Name { get; set; } 
  

        [Required]

[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
public  DateTime TimeStamp { get; set; }
       
        
        public  Boolean IsMail { set; get; }
    
        [Required]
        public  int NotificationID { get; set; }
        

        [Required]
        public  int NoteTypeID { get; set; }

       

    }
}
