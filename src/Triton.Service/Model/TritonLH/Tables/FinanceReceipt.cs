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
    [Table("FinanceReceipts")]
   public class FinanceReceipts
    {
        [Dapper.Contrib.Extensions.Key]
        public int FinanceReceiptID { get; set; }
        [Computed]
        public string ReceiptRef { get; set; }
        [DisplayName("Customer")]
        public int CustomerID { get; set; }
        [DisplayName("Receipt Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime ReceiptDate { get; set; }
        [DisplayName("Amount")]
        public Decimal ReceiptAmt { get; set; }
        public int FinMonth { get; set; }
        public int FinPeriod { get; set; }
        public int FinYear { get; set; }
        public string Comment { get; set; }

        public string BankRef { get; set; }

        [DisplayName("Created By")]
        public int? CreatedByUserID { get; set; }

      [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        [DisplayName("Created On")]
        public DateTime? CreatedOn { get; set; }

       
        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

        [DisplayName("Deleted On")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? DeletedOn { get;  set; }

    }
}
