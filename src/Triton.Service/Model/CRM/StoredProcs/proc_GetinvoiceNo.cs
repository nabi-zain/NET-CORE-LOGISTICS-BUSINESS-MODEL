using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_GetinvoiceNo
    {
        public int InvoiceID { get; set; }
        public string InvoiceNo { get; set; }
        public string AccountCode { get; set; }
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
