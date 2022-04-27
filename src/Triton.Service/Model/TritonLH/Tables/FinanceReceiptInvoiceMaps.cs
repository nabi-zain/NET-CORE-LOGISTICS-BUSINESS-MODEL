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
    [Dapper.Contrib.Extensions.Table("FinanceReceiptInvoiceMaps")]
   public class FinanceReceiptInvoiceMaps
    {
        [Dapper.Contrib.Extensions.Key]
        public int FinanceReceiptInvoiceMapID { get; set; }
        [DisplayName("Invoice")]
        public  int FinanceInvoiceID { get; set; }
        [DisplayName("Receipt")]
        public int FinanceReceiptID { get; set; }

        [DisplayName("Created On")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }"  ,ApplyFormatInEditMode=true)]
        public DateTime? CreatedOn { get; set; }

        [DisplayName("Created By")]
        public int? CreatedByUserID { get; set; }

        [DisplayName("Deleted On")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? DeletedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedByUserID { get; set; }

    }
}
