using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.HelpDesk.StoredProcs
{
    public class proc_eMobile_Insert
    {
        public int CallID { get; set; }
        public int CallEmployeeID { get; set; }
        public int BranchID { get; set; }
        public int DepartmentID { get; set; }
        public int UserID { get; set; }
        public DateTime TimeofCall { get; set; }
        public int PriorityID { get; set; }
        public int CategorySubCategoryMapID { get; set; }
        public byte Resloved { get; set; }
        public string Resolution { get; set; }
        public int reslovedByUserID { get; set; }
        public int Status { get; set; }
        public int EngineerID { get; set; }
        public int SubCategoryFailureSourceID { get; set; }
        public int OrgPostID { get; set; }

    }
}
