using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using Triton.Model.TritonOps.Tables;

namespace Triton.Model.Applications.Tables
{
    [Table("tblWorkFlowRoleStages")]
     public class tblWorkFlowRoleStages
    {
        [Dapper.Contrib.Extensions.Key]
        public  int StageRoleID { get; set; }
      
        [Required]
        public  int RoleID { get; set; }
  
 
        [Required]
        public  int WorkFlowStageID { get; set; }
   
    }
}
