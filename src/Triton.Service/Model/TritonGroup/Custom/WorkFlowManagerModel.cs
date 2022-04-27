using System;

namespace Triton.Service.Model.TritonGroup.Custom
{
    public class WorkFlowManagerModel
    {
        public int WorkID { get; set; }
        public int ? RecordID { get; set; }
        public int ? StageID { get; set; }
        public int ? AssignedtoID { get; set; }
        public int ? TaskID { get; set; }
        public int ? UserID { get; set; }
        public DateTime ? WorkDate { get; set; }
        public string Comments { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? WorkFlowID { get; set; }
        public string KeyName { get; set; }
        public string WorkFlowStage { get; set; }
        public string UserName { get; set; }
        public int WorkFlowStageID { get; set; }

    }
}
