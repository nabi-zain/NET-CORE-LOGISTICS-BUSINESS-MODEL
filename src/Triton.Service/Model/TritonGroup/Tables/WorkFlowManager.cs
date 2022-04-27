using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("WorkFlowManager")]
    public class WorkFlowManager
    {
        [Dapper.Contrib.Extensions.Key]
        public Int64 WorkFlowManagerID { get; set; }

        public int WorkFlowID { get; set; }

        public int WorkFlowStageID { get; set; }
        public int? RecordID { get; set; }
        public int? AssignedtoID { get; set; }
        public int? AssignedtoBranchID { get; set; }
        public int? WorkFlowTaskID { get; set; }

        public int? UserID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? WorkDate { get; set; }
        public string Comments { get; set; }

        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? CreatedDate { get; set; }

        [DisplayName("WorkFlow Stage")]
        [Write(false)]
        [Computed]
        public string WorkFlowStage { get; set; }

        //[DisplayName("Action")]
        //[Write(false)]
        //[Computed]
        //public string WorkFlowTask { get; set; }

        [DisplayName("User")]
        [Write(false)]
        [Computed]
        public string Name { get; set; }
    }
}
