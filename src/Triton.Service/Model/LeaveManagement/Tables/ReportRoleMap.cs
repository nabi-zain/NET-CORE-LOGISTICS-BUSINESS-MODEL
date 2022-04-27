using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("ReportRoleMap")]
    public class ReportRoleMap
    {
        [Key]
        public int ID { get; set; }
        public int? ReportID { get; set; }
        public int? RoleID { get; set; }
    }
}
