using Dapper.Contrib.Extensions;

namespace Triton.Model.HelpDesk.Tables
{
    [Table("Roles")]
    public class Roles
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
