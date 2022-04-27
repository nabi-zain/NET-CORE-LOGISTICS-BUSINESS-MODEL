using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
   public class tblWorkFlowRoleStagesModels
    {
      public tblWorkFlowRoleStages StageRole { get; set; } 
        public tblRoles Role { get; set; }

        public tblWorkFlowRoleStages WorkFlowStages { get; set; }
    }
}
