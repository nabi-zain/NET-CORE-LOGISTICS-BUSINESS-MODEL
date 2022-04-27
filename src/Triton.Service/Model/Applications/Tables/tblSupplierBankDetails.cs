using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Models.PurchaseOrders.Tables
{
    [Table("tblSupplierBankDetails")]
    public class tblSupplierBankDetails 
    {
        [Dapper.Contrib.Extensions.Key]
        public int SupplierBankID { get; set; }
        public int SupplierID { get; set; }
        [DisplayName("Bank Name")]
        [Required]
        public string BankName { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        
        public string BranchCode { get; set; }
        [DisplayName("Branch Name")]
        [Required]
        public string BranchName { get; set; }

    }
}

