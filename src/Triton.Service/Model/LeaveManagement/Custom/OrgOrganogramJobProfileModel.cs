using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.LeaveManagement.Tables;

namespace Triton.Service.Model.LeaveManagement.Custom
{
    public class OrgOrganogramJobProfileModel
    {
        public string extReferenceNo { get; set; }
        public string Description { get; set; }
        public bool orgActive { get; set; }

        public int OrgID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string BranchFullName { get; set; }
    }
}
