using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("Invoices")]
    public class Invoices
    {
        [Key]
        public int InvoiceID { get; set; }
        public string InvoiceNo { get; set; }
        public int CustomerID { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? InvoicePeriod { get; set; }
    }
}
