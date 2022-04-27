using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("PersonalEmployeeMaps")]
    public class PersonalEmployeeMaps
    {
        public int PersonalEmployeeMapID { get; set; }
        public int UserID { get; set; }
        public int EmployeeID { get; set; }
    }
}
