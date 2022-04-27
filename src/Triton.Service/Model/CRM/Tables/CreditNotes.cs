using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    public class CreditNotes
    {
        public long CreditNoteID { get; set; }
        public int CustomerID { get; set; }
        public string WaybillNumber { get; set; }
        public decimal AmountEx { get; set; }
        public string CreditNoteRef { get; set; }
        public string Remarks { get; set; }
        public string DebitNoteRef { get; set; }
        public int CRDRReasonCodeID { get; set; }
        public int FinanceYear { get; set; }
        public int FinanceMonth { get; set; }
        public long WaybillID { get; set; }
    }
}
