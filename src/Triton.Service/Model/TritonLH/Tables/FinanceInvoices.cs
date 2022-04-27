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
    [Table("FinanceInvoices")]
   public class FinanceInvoices
    {
        [Dapper.Contrib.Extensions.Key]
        public int FinanceInvoiceID { get; set; }
        [Computed]
        public string InvoiceRef { get; set; }
        [DisplayName("Customer")]
        public int CustomerID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime InvoiceDate { get; set; }
        public string Comments { get; set; }
        public int FinMonth { get; set; }
        public int FinYear { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}" ,ApplyFormatInEditMode=true)]
        [DisplayName("Created On")]
        public DateTime? CreatedOn { get; set; }

        [DisplayName("Created By")]
        public int? CreatedByUserID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}",ApplyFormatInEditMode=true)]
        [DisplayName("Deleted On")]
        public DateTime? DeletedOn { get; set; }

        [DisplayName("Deleted By")]
        public int? DeletedbyUserID { get; set; }
        [DisplayName("COD Customer")]
        public string CODCustomerName { get; set; }
        [DisplayName("COD Address1")]
        public string CODAddress1 { get; set; }
        [DisplayName("COD Address2")]
        public string CODAddress2 { get; set; }
        [DisplayName("COD Address3")]
        public string CODAddress3 { get; set; }
        [DisplayName("COD Address4")]
        public string CODAddress4 { get; set; }
        [DisplayName("COD PostalCode")]
        public string CODPostalCode { get; set; }
        [DisplayName("COD VatReg")]
        public string CODVatReg { get; set; }
        [DisplayName("COD Contact")]
        public string CODContactName { get; set; }
        [DisplayName("COD ContactNo.")]
        public string CODContactNumber { get; set; }
        [DisplayName("Tax Rate")]
        public int TaxRateID { get; set; }

    }
}
