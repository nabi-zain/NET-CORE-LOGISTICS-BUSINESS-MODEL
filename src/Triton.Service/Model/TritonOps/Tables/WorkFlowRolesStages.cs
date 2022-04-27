using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Triton.Model.TritonOps.Tables
{
    [Table("WorkFlowRolesStages")]
    public class WorkFlowRolesStages
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]

        public int StageRoleID { get; set; }

        public int RoleID { get; set; }

        public int WorkFlowStageID { get; set; }

        public bool CanModifyControls { get; set; }

        public bool AllowWorkFlowMovement { get; set; }
    }
}
