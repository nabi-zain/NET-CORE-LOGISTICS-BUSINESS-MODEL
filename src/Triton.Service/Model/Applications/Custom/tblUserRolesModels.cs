using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
  public class tblUserRolesModels
    {
       public tblUserRoles UserRole { get; set; } 
        public tblUsers User { get; set; }
        public tblRoles Role { get; set; }

    }
}
