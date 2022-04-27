using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Triton.Model.TritonOps.Tables
{
    [Table("WorkFlowManager")]
    public class WorkFlowManager
    {
        [Required]
        [Dapper.Contrib.Extensions.Key]

        public int WorkID { get; set; }

        public int RecordID { get; set; }

        public int StageID { get; set; }

        public int AssignedtoID { get; set; }

        public int TaskID { get; set; }

        public int UserID { get; set; }

        public DateTime? WorkDate { get; set; }

        public string Comments { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int WorkFlowID { get; set; }

        public int AssignedtoBranchID { get; set; }
    }
}
