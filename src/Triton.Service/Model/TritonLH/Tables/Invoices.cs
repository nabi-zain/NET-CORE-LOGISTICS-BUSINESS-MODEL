using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.TritonLH.Tables
{
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        public int InvoiceID { get; set; }

        [DisplayName("Invoice No")]
        public string InvoiceNo { get; set; }

        [DisplayName("Invoice Date")]
        public DateTime? InvoiceDate { get; set; }

        [DisplayName("Created By")]
        public int? CreatedByUserID { get; set; }

        [DisplayName("Created On")]
        public DateTime? CreatedOn { get; set; }

        [DisplayName("Waybill No")]
        public string WaybillNo { get; set; } // bigint, null

        [DisplayName("Waybill Date")]
        public DateTime? WaybillDate { get; set; } // nchar(10), null

        public bool? InvoicePaid { get; set; }

    }
}
