using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblBranchPettyCash")]
    public class tblBranchPettyCash
    {
      
      
       [Key]
        public int PettyCashID { get; set; }
        public int Branch { get; set; }

        [DisplayName("Branch")]
        public int BranchID { get; set; }

        public string Description { get; set; }

        [DisplayName("Petty Cash Float")]
        public Decimal PettyCashFloat { get; set; }
    }
}
