using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ServiceTimers")]
    public class ServiceTimers
    {
        [Key]
        public int ServiceTimerID { get; set; }
        public Boolean AlreadyFailed { get; set; }
        public DateTime? FailedAt { get; set; }
        public DateTime LastServiceRun { get; set; }
        public String ServiceName { get; set; }
    }
}
