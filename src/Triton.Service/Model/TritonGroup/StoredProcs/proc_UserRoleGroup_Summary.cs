using System;

namespace Triton.Service.Model.TritonGroup.StoredProcs
{
    public class proc_UserRoleGroup_Summary
    {
        public int UserRoleGroupID { get; set; }
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
        public string SystemName { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
