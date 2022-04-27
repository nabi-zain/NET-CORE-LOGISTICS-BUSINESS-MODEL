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
    [Table("tblMasterBranchesAudit")]
    public class tblMasterBranchesAudit
    {  
       [Dapper.Contrib.Extensions.Key]
            public int AuditID { get; set; }

            [DisplayName("Branch")]
            public int BranchID { get; set; }

        
            public int AuditEventTypeID { get; set; }


            [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
            public DateTime AuditDate { get; set; }
        
        [DisplayName("User Name")]
        public string UserName { get; set; }
        

        public string AuditDetails { get; set; }
        }
}
