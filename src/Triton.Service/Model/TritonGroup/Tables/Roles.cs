using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonGroup.Tables
{
    public class Roles
    {
        [Required]
        public int RoleID { get; set; }

        [Required]
        public string RoleName { get; set; }

        public string Detail { get; set; }
    }
}
