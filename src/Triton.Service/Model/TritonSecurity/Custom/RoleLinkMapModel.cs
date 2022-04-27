using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
namespace Triton.Model.TritonSecurity.Custom
{
   public class RoleLinkMapModel
    {
        public RoleLinkMap RoleLinkMap { get; set; }
        public Users Users { get; set; }
        public Roles Roles { get; set; }


    }
}
