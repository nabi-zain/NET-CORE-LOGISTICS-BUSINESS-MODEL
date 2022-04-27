using System.Collections.Generic;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.CRM.Tables;

namespace Triton.Service.Model.CRM.Custom
{
    public class CSAAuditNoteModel
    {
        public List<CSAAuditNote> CSAAuditNote { get; set; }
        public Users Users { get; set; }
        public Customers Customers { get; set; }
    }
}
