using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblGlBranch")]
   public class tblGLBranches
    {
        
        [System.ComponentModel.DataAnnotations.Key]
    public int GLBrID { get; set; }

    
    public int GLCodeID { get; set; }

   [Required]
    public  int BranchID { get; set; }
   
    

       }
}
