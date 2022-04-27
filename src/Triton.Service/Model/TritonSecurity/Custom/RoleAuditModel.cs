using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
namespace Triton.Model.TritonSecurity.Custom
{
   public class RoleAuditModel
    {
        public RoleAudit RoleAudits { get; set; }
        public Users Users { get; set; }


    }
}
