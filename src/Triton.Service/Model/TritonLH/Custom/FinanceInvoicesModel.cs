using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class FinanceInvoicesModel
    {
        public FinanceInvoices FinanceInvoice { get; set; }
        public Customers Customer { get; set; }
        public Triton.Model.TritonGroup.Tables.Users CreatedByUser { get; set; }
        public Triton.Model.TritonGroup.Tables.Users DeletedByUser { get; set; }
        public TritonGroup.Tables.TaxRates TaxRate { get; set; }
    }

    public class FinanceInvoicesEditModel
    {
        public FinanceInvoicesModel FinanceInvoiceModel { get; set; }
        public List<Customers> Customers { get; set; }
        public List<TritonGroup.Tables.TaxRates> TaxRates { get; set; }

    }

   
}

