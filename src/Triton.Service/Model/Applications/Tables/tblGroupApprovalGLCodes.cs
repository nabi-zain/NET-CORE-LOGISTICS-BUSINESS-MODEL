using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblGroupApprovalGLCodes")]
   public class tblGroupApprovalGLCodes
    { 
    
        [Key]
        public  int GroupApprovalGLCodeID { get; set; }
        public  int GLCodeID { get; set; }
        [DisplayName("Group Approval")]
        public  int GroupApprovalID { get; set; }
    }
}
