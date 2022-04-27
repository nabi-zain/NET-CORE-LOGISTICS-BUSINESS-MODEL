using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblGroupApprovalUser")]
   public class tblGroupApprovalUsers
    {
        [Key]
        public  int GroupApprovalUsersID { get; set; }

        [DisplayName("User Name")]
        public  int UserID { get; set; }
       
        public  int GroupApprovalID { get; set; }
    }
}
