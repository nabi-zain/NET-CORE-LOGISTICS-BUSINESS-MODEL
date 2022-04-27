using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.CRM.Tables;

namespace Triton.Model.CRM.Custom
{
    public class InvoiceSearchModel
    {

        public List<proc_GetinvoiceNo> proc_InvoiceNo { get; set; }
        public string InvoiceNo { get; set; }
        public int CustomerId { get; set; }
        public DateTime StartDate { get; set; }  = DateTime.Now.AddDays(-14);
        public DateTime EndDate { get; set; } = DateTime.Now;
        public List<Customers> AllowedCustomerList { get; set; }
        public string FilterDate { get; set; }
        public bool ShowReport { get; set; }
    }
}
