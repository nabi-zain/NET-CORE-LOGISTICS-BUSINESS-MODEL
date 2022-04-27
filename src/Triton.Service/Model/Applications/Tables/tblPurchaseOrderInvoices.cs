using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPurchaseOrderInvoices")]
    public class tblPurchaseOrderInvoices
    {
        [Dapper.Contrib.Extensions.Key]
        public int InvoiceID { get; set; } 


        [Required]
        [DisplayName("PurchaseOder")]
        public int? PurchaseOrderID { get; set; } 

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? InvoiceDate { get; set; }       

        [Required]
        public string InvoiceComments { get; set; } 

        [Required]
        public decimal? InvoiceTotal { get; set; } 

        [Required]
        public bool? AdditionalPO { get; set; }     

        [Required]
        public string InvoiceNumber { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? DateAdded { get; set; }       
        [Required]
        public string ManifestNo { get; set; }        
        [Required]
        public string LabourBrokerName { get; set; } 
    }

}
