using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.Tables
{
    [Dapper.Contrib.Extensions.Table("FinanceCreditNotes")]
    public class FinanceCreditNotes
    {
        [Dapper.Contrib.Extensions.Key]
        public int FinanceCreditNoteID { get; set; }
        [Computed]
        [DisplayName("Reference ")]
        public string CreditNoteRef { get; set; }

        [DisplayName("Credit Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CreditDate { get; set; }
        [DisplayName("Customer")]
        public int CustomerID { get; set; }
        public string Comments { get; set; }
        [DisplayName("Ref Invoice")]
        public int RefInvoiceID { get; set; }
        [DisplayName("Credit Reason")]
        public int CreditReasonLCID { get; set; }

        [DisplayName("Created On")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}" ,ApplyFormatInEditMode=true)]
        public DateTime? CreatedOn { get; set; }


        [DisplayName("Created by")]
        public int? CreatedByUserID { get; set; }
        
        [DisplayName("Deleted On")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }",ApplyFormatInEditMode=true)]
        public DateTime? DeletedOn { get; set; }

        [DisplayName("Deleted by")]
        public int? DeletedByUserID { get; set; }
        [DisplayName("Fin Month")]
        public int FinMonth { get; set; }
        [DisplayName("Fin Period")]
        public int FinPeriod { get; set; }
        public decimal Amount { get; set; }
        [DisplayName("Tax Rate")]
        public int TaxRateID { get; set; }

    }
}
