using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using Triton.Model.TritonGroup.Tables;

namespace Triton.Model.Applications.Tables
{
    [Table("tblWorkFlowTask")]
   public class tblWorkFlowTasks
    {


        [Dapper.Contrib.Extensions.Key]
        public  int WorkFlowTaskID { get; set; }

        [Required]
        public  int WorkFlowStageID { get; set; }
        
        [Required]

        public  WorkFlowStages Stage { get; set; }
        
        [Required]
        public  string WorkFlowTask { get; set; }
        
        [Required]
        public  int FlowID { get; set; }
        
        [Required]
        public  int SendNotification { get; set; }
        

        [Required]
        public  int Status { set; get; }
       

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime StatusDate { get; set; }
       

        public  string Icon { get; set; }
       

        public  bool RequiresValidation { get; set; }

    }
}

