using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.HelpDesk.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.HelpDesk.StoredProcs
{
    public class procr_UnresolvedHelpDeskIssuesByEngineer
    {
        public string HelpDeskGroup { get; set; }
        public int CallID { get; set; }
        public int CallerEmployeeID { get; set; }
        public string BranchFullName { get; set; }
        public Departments Departments { get; set; }
        public DateTime TimeofCall { get; set; }
        public int PriorityID { get; set; }
        public int CategorySubCategoryMapID { get; set; }
        public string Resolution { get; set; }
        public DateTime TimeofResolution { get; set; }
        public int ReslovedUserID { get; set; }
        public int StatusID { get; set; }
        public int SubCategoryFailureSourceID { get; set; }
        public int EngineerID { get; set; }
        public string EngineerName { get; set; }
        public int UserID { get; set; }
        public byte Active { get; set; }
        public string Payroll { get; set; }
        public string ProblemDescripition { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}
