using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("OvertimeTreshHold")]
    public class OvertimeTreshHold
    {
        [Key]
        public int OvertimeTreshholdID { get; set; }
        public int BranchId { get; set; }
        public int TreshholdValue { get; set; }
    }
}
