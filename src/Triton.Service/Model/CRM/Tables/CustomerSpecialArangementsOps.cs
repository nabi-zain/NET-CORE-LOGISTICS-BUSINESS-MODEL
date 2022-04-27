using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerSpecialArangementsOps")]
    public class CustomerSpecialArangementsOps
    {
        [Key]
        public int CustomerSpecialArangementsOpID { get; set; }
        public int CustomerID { get; set; }
        public string Arrangement { get; set; }
        public int OPSBranchID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte Removed { get; set; }
    }
}
