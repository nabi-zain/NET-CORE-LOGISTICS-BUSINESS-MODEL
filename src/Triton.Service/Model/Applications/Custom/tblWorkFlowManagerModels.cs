using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.TritonGroup.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblWorkFlowManagerModels
    {

        public tblWorkFlowManager WorkFlowManager { get; set; }
        public WorkFlowStages Stage { get; set; }
        public tblWorkFlowTasks Task { get; set; }
        public Tables.tblUsers User { get; set; }
        public WorkFlows WorkFlow { get; set; }
   
        

}
}
