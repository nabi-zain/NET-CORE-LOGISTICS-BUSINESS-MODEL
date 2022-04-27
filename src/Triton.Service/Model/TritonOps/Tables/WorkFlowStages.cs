using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Triton.Model.TritonOps.Tables
{
    [Table("WorkFlowStages")]
    public class WorkFlowStages
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]

        public int WorkFlowStageID { get; set; }

        public string WorkFlowStage { get; set; }

        public string WorkFlowPageName { get; set; }

        public int OrderBy { get; set; }

        public string StageHelp { get; set; }

        public int WorkFlowID { get; set; }
    }
}
