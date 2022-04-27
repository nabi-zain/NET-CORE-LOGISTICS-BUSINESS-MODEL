using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("VipImportTasks")]
    public class VipImportTasks
    {
        public int ID { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? TaskID { get; set; }
        public int? EmployeeID { get; set; }
        public string CreatedBy { get; set; }
        public string Comment { get; set; }
    }
}
