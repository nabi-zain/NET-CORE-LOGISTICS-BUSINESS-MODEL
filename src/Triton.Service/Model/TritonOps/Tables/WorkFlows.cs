using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonOps
{
    [Table("WorkFlows")]
    public class WorkFlows
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]

        public int WorkFlowID { get; set; }

        public string WorkflowName { get; set; }
    }
}
