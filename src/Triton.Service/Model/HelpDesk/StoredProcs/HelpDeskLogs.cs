using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.HelpDesk.Tables;

namespace Triton.Model.HelpDesk.StoredProcs
{
    public class HelpDeskLogs
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
        public string EngineerID { get; set; }
        public string WorkingDaysOutstanding { get; set; }
        public byte OrderBy { get; set; }
        public int CallID { get; set; }
        public string RouteName { get; set; }

    }
}
