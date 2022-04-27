using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPurchaseorders")]
    public class tblPurchaseOrders
    {
        [Dapper.Contrib.Extensions.Key]
        public int PurchaseOrderID { get; set; }

        [Required]
        public string PurchaseOrderRef { get; set; }
        [Required]
        public int? PurchaseOrderTypeID { get; set; }

        
        [DisplayName("Branch")]
        public int BranchID { get; set; }

        [Required]
        [DisplayName("Vehicle")]
        public int? VehicleID { get; set; }
        [Required]
        [DisplayName("Expense type")]
        public int? ExpenseTypeID { get; set; }
        [Required]
        [DisplayName("From Branch")]
        public int? FromBranchID { get; set; }
        [Required]
        [DisplayName("To Branch")]
        public int? ToBranchID { get; set; }

        [Required]
        [DisplayName("Reason")]
        public int? ReasonID { get; set; }

        [Required]
        [DisplayName("Details")]
        public string Details { get; set; }
        [Required]
        public int? TonnageID { get; set; }
        [Required]
        public int? ConfigID { get; set; }
        [Required]
        public int? PaymentTypeID { get; set; }
        [Required]
        [DisplayName("Supplier")]
        public int? SupplierID { get; set; }
        [Required]
        public bool? EmailSupplier { get; set; }
        [Required]
        public string SupplierInstructions { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? DateExpected { get; set; }
        
        [DisplayName("Requested")]
        public int RequestedByID { get; set; }
        
        [DisplayName("CreatedBy")]
        public int CreatedByID { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedDateTime { get; set; }
      
        [Required]
        public bool? Exported { get; set; }
        [Required]
        public DateTime? ExportedDate { get; set; }
        [Required]
        [DisplayName("Department")]
        public int? DepartmentID { get; set; }
        [Required]
        public string AdditionalRef { get; set; }
        [Required]
        public bool PaidbyCheque { get; set; }
        [Required]
        public string ChequeReference { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? TripDate { get; set; }
        [Required]
        public int? CountryID { get; set; }
        [Required]
        public decimal? ExchangeRateToRand { get; set; }
        [Required]
        public int? GroupApprovalID { get; set; }
        [Required]
        public bool? GroupApprovalEmail { get; set; }
        [Required]
        [DisplayName("PettyCash")]
        public int? PettyCashID { get; set; }
        
        public bool ForexPostedToFinancialSystem { get; set; }
      
        public bool ForexBalancedToReceipts { get; set; }
    
        public bool PriorityCOD { get; set; }
    }
}
