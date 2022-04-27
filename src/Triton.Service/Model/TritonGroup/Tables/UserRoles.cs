using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("UserRoles")]
    public class UserRoles
    {
        [Dapper.Contrib.Extensions.Key]
        public int UserRoleID { get; set; }

        [Required]
        public int UserID { get; set; }

        //public string Name { get; set; }

        [Required]
        public int RoleID { get; set; }

        public int? BranchId { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        public int CreatedByUserID { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? DeletedByUserID { get; set; }

    }
}
