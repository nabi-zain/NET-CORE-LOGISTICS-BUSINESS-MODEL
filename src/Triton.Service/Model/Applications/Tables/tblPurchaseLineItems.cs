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
    [Table("tblPurchaseLineItems")]
    public class tblPurchaseLineItems
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int LineItemID { get; set; }

        public bool ClaimVAT { get; set; }
        
        public string Days { get; set; }


        public string Description { get; set; }
      

        [Required]
        public  string Duration { get; set; }
        

        public bool Exclude { get; set; }

        public Decimal ExcludingVATAmount { get; set; }

        public string GLCodeID { get; set; }
  
        
        public string HireDescription { get; set; }
     
     ///public string LabourTypeID { get; set; }

        [Required]

        public string LineHaulTypeName { get; set; }
       
     
      
        public Decimal LineTotal { get; set; }
     
        public Decimal LineTotalEx { get; set; }
        
        public bool No_Vat { get; set; }

        
       /// public int PurchaseOrderID { get; set; }
        

        public decimal Quantity { get; set; }
    
        public bool? Receipt { get; set; }

        public string Supplier { get; set; }

     
        [Required]
        public Decimal Total { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? TxDate { get; set; }

        [DisplayName("Unit Amount")]
        public decimal UnitAmount { get; set; }

        [Required]
        public Decimal VATAmount { get; set; }
        

        [Required]
        public bool VATIncluded { get; set; }

        public Decimal VATRate { get; set; }

        ///public int? VehConfigID { get; set; }
       

        ///public int VehExpenseDetails { get; set; }
       /// public string VehExpenseTypeName { get; set; }

        
       /// public int? VehHireID { get; set; }
      
        
        ///public int? VehicleTypeID { get; set; }
       
       
       /// public int? VehTonnageID { get; set; }

/*
          
        [Required]
        public string AMEXRef { get; set; }


        [Required]
        public bool TxPosted { get; set; }
      [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? FuelDeliveryDate { get; set; }
        */

        ///[Required]
      ///  public string RevenueInvoice { get; set; }


    }
}

        

    

