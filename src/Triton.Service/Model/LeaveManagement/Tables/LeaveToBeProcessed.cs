using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LeaveToBeProcessed")]
    public class LeaveToBeProcessed
    {
        [Key]
        public int LeaveID { get; set; }
    }
}
