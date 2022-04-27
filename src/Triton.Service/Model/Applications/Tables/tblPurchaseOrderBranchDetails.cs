using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPurchaseOrderBatchDetails")]
    public class tblPurchaseOrderBranchDetails
    {


        [Key]
        public int BatchDetailID { get; set; }
     

        public int BatchHeaderID { get; set; }
        

        [DisplayName("CellNo")]
        public string CellNo { get; set; }
   
        public string PukNo { get; set; }
      

        [DisplayName("Branch")]
        public string Branch { get; set; }
   

        public string UserID { get; set; }


        public string UserCode { get; set; }
    

        public string Billing { get; set; }
        

        public string Allowance { get; set; }
      

        public string StaffAdvBlackberry { get; set; }
 

        public string ChgToSalary { get; set; }
  
        public string Allocation { get; set; }
 

        public string ExcludingVAT { get; set; }
  
    }
}


