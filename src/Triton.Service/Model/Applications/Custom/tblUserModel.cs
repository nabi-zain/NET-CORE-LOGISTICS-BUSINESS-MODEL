using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.Applications.Custom
{
    public class tblUserModel
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public int DepartmentID { get; set; }

        public string Department { get; set; }

        public int BranchID { get; set; }

        public string BranchName { get; set; }

        public string Name { set; get; }

        public string EmailAddress { set; get; }

        public string Archive_User { get; set; }

        public int ManagerID { get; set; }

        public int IsHeadOffice { get; set; }

        public int StatusID { get; set; }

        public DateTime StatusDate { get; set; }
    }
}
