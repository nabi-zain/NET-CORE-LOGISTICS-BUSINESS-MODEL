using System.Collections.Generic;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonOps.Views;

namespace Triton.Model.TritonOps.Custom
{
    public class WorkFlowCustomModel
    {
        public WorkFlowManager WorkFlowManager { get; set; }



        public WorkFlowRolesStages WorkFlowRolesStages { get; set; }

        public WorkFlowStages WorkFlowStages { get; set; }

        public WorkFlows WorkFlows { get; set; }

        public WorkflowTasks WorkflowTasks { get; set; }

        public vw_Drivecam vw_Drivecam { get; set; }
       
    }

    public class CustomDriveCamModel
    {
        public long DrivecamID { get; set; }
        public int TotalInbox { get; set; }

        public int TotalBMReview { get; set; }

        public int TotalComplete { get; set; }

        public int TotalArchived { get; set; }

        public int TotalAutoArchived { get; set; }

        public int TotalManualArchived { get; set; }

        public int TotalDownload { get; set; }
        public List<WorkFlowStages> WorkFlowStages { get; set; }
    }
}
