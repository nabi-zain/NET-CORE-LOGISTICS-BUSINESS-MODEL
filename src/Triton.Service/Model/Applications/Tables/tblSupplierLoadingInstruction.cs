using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblSupplierloadingInstructions")]
    public class tblSupplierLoadingInstruction 
    {
        [Dapper.Contrib.Extensions.Key]
        public int LoadingInstructionID { get; set; }
        [DisplayName("Purchase Order")]
        public int PurchaseOrderID { get; set; }
        [Required]
        [DisplayName("Cargo Value")]
        public decimal CargoValue{ get; set; }
        [Required]
        public decimal Rate { get; set; }
        [Required]
        public decimal Tonnage { get; set; }
        [Required]
        [DisplayName("Total")]
        public decimal Total { get; set; }
        [Required]
        public string AttentionFor{ get; set; }
        [Required]
        public string Commodity { get; set; }
        [Required]
        public string PaymentMade { get; set; }
        [Required]
        [DisplayName("Veicle Type")]
        public string VehicleType { get; set; }
        [Required]
        public string VehicleReg { get; set; }
        [Required] 
        [DisplayName("Collection Address")]
        public string CollectionAddress { get; set; }
        [Required]
        public string DeliveryAddress { get; set; }
        [Required]
        public string CreatedByUser { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? CreatedDate { get; set; }
      
    }
}




