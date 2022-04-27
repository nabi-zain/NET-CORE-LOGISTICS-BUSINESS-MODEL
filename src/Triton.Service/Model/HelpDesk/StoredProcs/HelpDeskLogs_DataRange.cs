using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.HelpDesk.StoredProcs
{

    class HelpDeskLogs_DataRange
    {
        public string BranchName { get; set; }
        public string Name { get; set; }
        public DateTime TimeofCall { get; set; }
        public string ProblemDescripition { get; set; }
        public string Priority { get; set; }
        public string CategoryDescripition { get; set; }
        public string Resolution { get; set; }
        public DateTime TimeOfResolution { get; set; }
        public string ReslovedUser { get; set; }
        public string Status { get; set; }
        public string EngineerName { get; set; }
        public int EngineerID { get; set; }
        public string WorkingDaysOutstanding { get; set; }
        public byte OrderBy { get; set; }
        public int CallID { get; set; }
     
    }
}
