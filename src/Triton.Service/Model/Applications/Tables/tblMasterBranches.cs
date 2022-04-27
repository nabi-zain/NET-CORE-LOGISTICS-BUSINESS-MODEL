using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
 {
    [Table("tblMasterBranchs")]
    public class tblMasterBranches
    {

        [Dapper.Contrib.Extensions.Key]
     [Required]
    public int BranchID { get; set; }

    [DisplayName("BranchCode")]
    [Required]
    public int BranchCode { set; get; }

    [DisplayName("Branch Name")]
    [Required]

    public string BranchName { set; get; }


     [DisplayName("Branch Full Branch Name")]
     [Required]
    public string BranchFullName { set; get; }
   
    [DisplayName("Branch Add 1")]
    [Required]

    public string BranchAdd1 { set; get; }
     [DisplayName("Branch Add 2")]
    [Required]
    public string BranchAdd2 { set; get; }
   
    [DisplayName("Branch Add 3")]
    [Required]

    public string BranchAdd3 { set; get; }
     [DisplayName("Branch Add 4")]
    [Required]
    public string BranchAdd4 { set; get; }
   
    [Required]
    public string BranchTel { set; get; }
   
    [Required]
    public string BranchFax { set; get; }
   
    
    public int BranchDailySalesOrder { set; get; }

        public override string ToString()
        {
            return BranchFullName;
        }


        [Required]
    public int CompanyID { get; set; }

}
}

