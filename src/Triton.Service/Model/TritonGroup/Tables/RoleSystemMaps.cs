using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("RoleSystemMaps")]
    public class RoleSystemMaps
    {
        [Dapper.Contrib.Extensions.Key]
        public int RoleSystemMapID { get; set; }
        public int RoleID { get; set; }
        public int SystemID { get; set; }
    }
}
