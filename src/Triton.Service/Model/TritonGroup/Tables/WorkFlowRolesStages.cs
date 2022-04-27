namespace Triton.Model.TritonGroup.Tables
{
    public class WorkFlowRolesStages
    {
        public int StageRoleID { get; set; }
        public Roles Roles { get; set; }
        public int? WorkFlowStageID { get; set; }
        public bool? CanModifyControls { get; set; }
        public bool? AllowWorkFlowMovement { get; set; }
    }
}
