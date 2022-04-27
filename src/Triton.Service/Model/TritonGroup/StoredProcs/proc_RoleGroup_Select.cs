using System;

namespace Triton.Service.Model.TritonGroup.StoredProcs
{
    public class proc_RoleGroup_Select
    {
        public int RoleGroupID { get; set; }
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string System { get; set; }
        public bool IsActive { get; set; }
    }
}
