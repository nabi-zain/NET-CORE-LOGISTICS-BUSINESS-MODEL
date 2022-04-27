using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("RoleLevels")]
   public class RoleLevels
    {
        [Key]
        public int RoleLevelID { get; set; }
        public int RoleLevel { get; set; }
        public int RoleLevelDescription { get; set; }

    }
}
