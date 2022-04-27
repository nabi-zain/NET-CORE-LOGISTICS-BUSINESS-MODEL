using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonInternalOrders.Tables
{
    [Table("ActivityLog")]
    public class ActivityLog
    {
        [Dapper.Contrib.Extensions.Key]
        public long ID { get; set; }
        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string TableName { get; set; }
        public string ActivityValue { get; set; }
        public DateTime LoggedOnDate { get; set; }
    }
}
