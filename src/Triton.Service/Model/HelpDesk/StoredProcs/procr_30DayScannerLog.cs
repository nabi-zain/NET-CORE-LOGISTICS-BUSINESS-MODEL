using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.HelpDesk.Tables;

namespace Triton.Model.HelpDesk.StoredProcs
{
    public class procr_30DayScannerLog
    {
        public string BranchName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Category { get; set; }
        public int CallID { get; set; }
        public string Status { get; set; }
        public string PriorityDescripition { get; set; }
        public string ErrorDescripition { get; set; }
        public string LoggedBy { get; set; }
        public int EMoblieID { get; set; }
        public int RouteID { get; set; }
        public string ROUTE { get; set; }
        public string ROUTENAME { get; set; }
        public int UserID { get; set; }
        public string ProblemDescripition { get; set; }
        public byte Resolution { get; set; }
        public string Logtype { get; set; }

    }
}
