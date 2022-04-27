using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class FinanceReceiptsModel
    {
        public FinanceReceipts FinanceReceipt { get; set; }
        public Customers Customer { get; set; }
        public Triton.Model.TritonGroup.Tables.Users CreatedByUser { get; set; }
        public Triton.Model.TritonGroup.Tables.Users DeletedByUser { get; set; }
        public FinanceInvoices FinanceInvoices { get; set; }

    }
        public class FinanceReceiptsEditModel
        {
           
            public FinanceReceiptsModel FinanceReceiptModel { get; set; }
            public List<Customers> Customers { get; set; }
            public List<FinanceInvoices> AllocatedInvoiceses { get; set; }
            public List<FinanceInvoices> InvoicesDue { get; set; }
        }

    public class FinanceReceiptSearch
    {
        public List<FinanceReceiptsModel> Receipts { get; set; }
    }




}
