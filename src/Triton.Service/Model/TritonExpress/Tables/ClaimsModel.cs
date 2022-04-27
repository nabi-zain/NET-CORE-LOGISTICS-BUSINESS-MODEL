using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Triton.Model.TritonExpress.Tables
{
     [Table("Claims")]
    public class ClaimsModel
    {
        [Dapper.Contrib.Extensions.Key]
        [DisplayName("Claim No.")]
        public Int64 ClaimID { get; set; }
        [DisplayName("Quantity No. to Claim**")]
        public int ClaimQuantity { get; set; }
         [DisplayName("Method Of Packaging**")]
        public int PackagingID { get; set; }
         [DisplayName("Commodity**")]
        public int CommodityID { get; set; }
        [DisplayName("Contents*")]
        public string Contents { get; set; }
          [DisplayName("Description Of Claim*")]
        public string ClaimDescription { get; set; }
        [DisplayName("Type")]
        public int ClaimTypeLookupCodeId { get; set; }
        [DisplayName("Insurance Type*")]
        public int Insurance { get; set; }

          [DisplayName("Consignment Value* eg 949.99")]
        public decimal ConsignmentValue { get; set; }
          [DisplayName("Amount Claimed* eg 949.99")]
        public decimal AmountClaimed { get; set; }

        [DisplayName("Waybill Copy")]
        [Write(false)]
        [Computed]
        public byte[] Waybill { get; set; }
        [DisplayName("Invoice Copy")]
        [Write(false)]
        [Computed]
        public byte[] TaxInvoice { get; set; }

        [DisplayName("Claim Form")]
        [Write(false)]
        [Computed]
        public byte[] ClaimForm { get; set; }
        public int UserID { get; set; }

        [DisplayName("Branch To Investigate*")]
        [Required]
        public int BranchIDInvestigating { get; set; }

        [DisplayName("Date")]
        public DateTime DateCaptured { get; set; }
        public string ClientEmailAddress { get; set; }

        [DisplayName("Branch Investigating")]
        [Write(false)]
        [Computed]
        public string BranchInvestigating { get; set; }

        [DisplayName("From")]
        [Write(false)]
        [Computed]
        public string FromBranch { get; set; }

        [DisplayName("From")]
        [Write(false)]
        [Computed]
        public int StatusID { get; set; }

        [DisplayName("From")]
        [Write(false)]
        [Computed]
        public int BranchID { get; set; }

        [DisplayName("To")]
        [Write(false)]
        [Computed]
        public string ToBranch { get; set; }

        [DisplayName("Customer Code")]
        [Write(false)]
        [Computed]
        public string AccountCode { get; set; }


        [DisplayName("Current Status")]
        [Write(false)]
        [Computed]
        public string Status { get; set; }

        [DisplayName("Waybill No.")]
        [Required(ErrorMessage = "Waybill No. Value is required!")]
        [Write(false)]
        [Computed]
        public string WaybillNo { get; set; }

        [DisplayName("Branch Liable")]
        [Write(false)]
        [Computed]
        public string BranchLiable { get; set; }

        [Required]
        [Write(false)]
        [Computed]
        [DisplayName("Waybills.")]
        public string Waybills { get; set; }

    }
}
