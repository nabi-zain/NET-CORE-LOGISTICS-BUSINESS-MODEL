
using Triton.Model.TritonSecurity.Tables;
namespace Triton.Model.TritonSecurity.Custom
{
  public  class RolesModel
    {
        public Roles Roles { get; set; }
        public Users Users { get; set; }
        public Systems Systems { get; set; }
        public RoleLevels RoleLevels { get; set; }
    }
}
