using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("FailedLeadNotes")]
    public class FailedLeadNotes
    {
        public int FailedLeadNoteID { get; set; }
        public int LeadID { get; set; }
        public int WorkFlowManagerID { get; set; }
        public DateTime TimeStamp { get; set; }
        public int LeadFailureID { get; set; }
        public string Note { get; set; }
        public DateTime TenderDate { get; set; }
        public int OppositionID { get; set; }
    }
}
