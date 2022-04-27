using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblSupplierApplication")]

    public class tblSupplierApplication
    {
        [Dapper.Contrib.Extensions.Key]
        public int SupplierApplicationID { get; set; }
        [DisplayName("Supplier")]
        public int SupplierID { get; set; }
        [Required]
        public bool ReplacesExistingSupplier { get; set; }

        [Required]
        public int ReplacedSupplierID { get; set; }
        [Required]
        public string ReplacedSupplierName { get; set; }
        [Required]
        public int SupplierReplacementReasonID { get; set; }
        [Required]
        public bool RatesBetter { get; set; }
        [Required]
        public bool RatesNegotiateBest { get; set; }

        [Required]
        [DisplayName("Comparative Quotes")]
        public bool ComparativeQuotes { get; set; }
        [Required]
        public bool NationalAccount { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)] public DateTime? AccountOpenDate { get; set; }
        public string ProceduresFollowed { get; set; }
        [Required]
        public int CreatedByID { get; set; }
        [Required]
        public int RequestedByID { get; set; }
        [Required]
        public int RequestedByBranchID { get; set; }
        [Required]
        public int AllocatedUserID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedDateTime { get; set; }
        public string WaybillNo { get; set; }
        public string ReplacementSupplier {get;set;}
        public string User { get; set; }
    }
}