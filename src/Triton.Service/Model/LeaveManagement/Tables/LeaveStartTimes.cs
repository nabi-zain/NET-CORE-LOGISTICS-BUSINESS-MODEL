using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveStartTimes")]
    public class LeaveStartTimes
    {
        [Key]
        public int LeaveStartTimeID { get; set; }
        public string LeaveStartTimeDescription { get; set; }
    }
}
