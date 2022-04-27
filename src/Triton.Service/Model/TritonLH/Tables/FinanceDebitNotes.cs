using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.Tables
{
    [Table("FinanceDebitNotes")]
    public class FinanceDebitNotes
    {

        [Dapper.Contrib.Extensions.Key]
        public int FinanceDebitNoteID { get; set; }

        [DisplayName("Reference")]
        [Computed]
        public string DebitNoteRef { get; set; }
        [DisplayName("Debit Date")]
       
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}" ,ApplyFormatInEditMode=true)]
        public DateTime DebitDate { get; set; }

        [DisplayName("Customer")]
        public int CustomerID { get; set; }

        public string Comments { get; set; }

        [DisplayName("Invoice")]
        public int? RefInvoiceID { get; set; }

        [DisplayName("Debit Reasons")]
        public int DebitReasonLCID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}" ,ApplyFormatInEditMode=true)]
        [DisplayName("Created On")]
        public DateTime? CreatedOn { get; set; }

        [DisplayName("Created By")]
        public int CreatedByUserID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}" ,ApplyFormatInEditMode=true)]
        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }
        [DisplayName("Fin Month")]
        public int FinMonth { get; set; }
        [DisplayName("Fin Year")]
        public int FinYear { get; set; }
        [DisplayName("Fin Period")]
        public int FinPeriod { get; set; }
        public Decimal Amount { get; set; }
        [DisplayName("Tax Rate")]
        public int TaxRateID { get; set; }

    }
}
