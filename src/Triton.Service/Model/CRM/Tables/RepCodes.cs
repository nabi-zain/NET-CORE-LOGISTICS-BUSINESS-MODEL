using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.CRM.Tables
{
    [Table("Repcodes")]
    public class RepCodes
    {
        [Key]
        public int RepCodeID { get; set; }
        public int UserID { get; set; }
        public string RepCode { get; set; }
        public byte Active { get; set; }
        public byte ActiveCommision { get; set; }
        public byte ServiceRep { get; set; }
        public string AlternateName { get; set; }    
        public string AlternateBranchCode { get; set; }
        public int AlternateOrderBy { get; set; } 
    }
}
