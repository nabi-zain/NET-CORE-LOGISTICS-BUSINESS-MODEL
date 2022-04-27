using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
   public class tblUserRoleBranchDepartmentMapsModels
    {
        public tblUserRoleBranchDepartmentMaps UserRoleBranchDepartmentID { get; set; }
        public tblUsers User { get; set; }
        public tblRoles Role { get; set; }
        public tblMasterBranches Branch { get; set; }
        public tblDepartments Department { get; set; }

    }
}
