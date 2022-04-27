using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class FinanceReceiptInvoiceMapsModel
    {
        public FinanceReceiptInvoiceMaps FinanceReceiptInvoiceMap { get; set; }
        public FinanceInvoices FinanceInvoice { get; set; }
        public FinanceReceipts FinanceReceipt { get; set; }
        public Triton.Model.TritonGroup.Tables.Users CreatedByUser { get; set; }
        public Triton.Model.TritonGroup.Tables.Users DeletedByUser { get; set; }
    }

    public class FinanceReceiptInvoiceMapsEditModel
    {
        public FinanceReceiptInvoiceMapsModel FinanceReceiptInvoiceMapModel { get; set; }
       
        public List<FinanceInvoices> FinanceInvoices { get; set; }
      

    }
  
}

