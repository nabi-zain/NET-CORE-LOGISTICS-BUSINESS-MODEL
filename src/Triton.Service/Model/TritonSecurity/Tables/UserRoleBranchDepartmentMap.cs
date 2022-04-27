using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("UserRoleBranchDepartmentMap")]
   public class UserRoleBranchDepartmentMap
    {
        [Key]
        public int UserRoleBranchDepartmentID { get; set; }
        public string UserID { get; set; }
        public string RoleID { get; set; }
        public int BranchID { get; set; }
        public int DepartmentID { get; set; }
        public string SigatoryTitle { get; set; }
        public string SignatoryTitle { get; set; }

    }
}
