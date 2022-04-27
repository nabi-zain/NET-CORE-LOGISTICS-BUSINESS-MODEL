using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("WorkReturnTimes")]
    public class WorkReturnTimes
    {
        [Key]
        public int WorkReturnTimeID { get; set; }
        public string WorkReturnTime { get; set; }
    }
}
