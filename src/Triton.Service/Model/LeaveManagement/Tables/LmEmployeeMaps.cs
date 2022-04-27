using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LmEmployeeMaps")]
    public class LmEmployeeMaps
    {
        [Key]
        public int ID { get; set; }
        public int? EmployeeID { get; set; }
        public int? LmID { get; set; }
    }
}
