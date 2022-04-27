using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.CRM.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class CreditNotesModel
    {
        public CreditNotes CreditNotes { get; set; }
        public Customers Customers { get; set; }
        public Waybills Waybills { get; set; }
        public CRDRNoteReasonCodes CrdrNoteReasonCodes { get; set; }
    }

    public class WaybillCreditModel
    {
        public long WaybillId { get; set; }
        public string WaybillNo { get; set; }
        public DateTime WaybillDate { get; set; }
        public decimal ChargesSubTotal { get; set; }
        public decimal Vat { get; set; }
        public decimal TotalValue { get; set; }
        public string AccountCode { get; set; }
        public string CustomerName { get; set; }
        public string FromBranch { get; set; }
        public string ToBranch { get; set; }
        public string Username { get; set; }
    }
}
