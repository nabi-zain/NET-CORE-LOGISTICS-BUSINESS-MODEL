using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("EmployeeUserMap")]
    public class EmployeeUserMap
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte Activated { get; set; }
    }
}
