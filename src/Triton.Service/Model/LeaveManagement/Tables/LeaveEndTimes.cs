using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveEndTimes")]
    public class LeaveEndTimes
    {
        [Key]
        public int LeaveEndTimeID { get; set; }
        public string LeaveEndTimeDescription { get; set; }
    }
}
