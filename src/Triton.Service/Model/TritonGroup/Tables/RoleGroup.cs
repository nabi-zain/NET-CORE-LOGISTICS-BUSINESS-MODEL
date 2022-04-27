using Dapper.Contrib.Extensions;
using System;

namespace Triton.Service.Model.TritonGroup.Tables
{
    [Table("RoleGroup")]
    public class RoleGroup
    {
        [Key]
        public int RoleGroupID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public int SystemID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
