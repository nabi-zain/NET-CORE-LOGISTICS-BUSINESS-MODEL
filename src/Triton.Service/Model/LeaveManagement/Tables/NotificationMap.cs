using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("NotificationMap")]
    public class NotificationMap
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public bool? EnableDayBefore { get; set; }
        public bool? EnableDayOff { get; set; }
    }
}
