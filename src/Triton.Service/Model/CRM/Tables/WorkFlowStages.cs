using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.CRM.Tables
{
    [Table("WorkFlowStages")]
    public class WorkFlowStages
    {
        [Key]
        public int WorkFlowStageID { get; set; }
        [Required]
        public string WorkFlowStage { get; set; }
        [Required]
        public string WorkFlowPageName { get; set; }
        [Required]
        public int OrderBy { get; set; }
        [Required]
        public string IconName { get; set; }
        [Required]
        public string StageHelp { get; set; }
        [Required]
        public int WorkFlowID { get; set; }
    }
}
