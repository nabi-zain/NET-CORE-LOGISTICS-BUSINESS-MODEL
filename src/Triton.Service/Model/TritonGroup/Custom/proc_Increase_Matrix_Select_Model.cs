using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonGroup.Custom
{
    public class proc_Increase_Matrix_Select_Model
    {
        public int ID { get; set; }
        public string WorkFlowStage { get; set; }
        public int WorkFlowStageID { get; set; }
        public int OrderBy { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }
        public string IconName { get; set; }
    }
}
