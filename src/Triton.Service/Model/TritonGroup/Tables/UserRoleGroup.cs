using Dapper.Contrib.Extensions;
using System;

namespace Triton.Service.Model.TritonGroup.Tables
{
    [Table("UserRoleGroup")]
    public class UserRoleGroup
    {
        [Key]
        public int UserRoleGroupID { get; set; }
        public int RoleGroupID { get; set; }
        public int UserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }
    }
}
