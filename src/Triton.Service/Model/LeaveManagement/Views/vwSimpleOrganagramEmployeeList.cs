using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Views
{
    [Table("vwSimpleOrganagramEmployeeList")]
    public class vwSimpleOrganagramEmployeeList
    {
        public int EmployeeID { get; set; }
        public int CostcentreID { get; set; }
        public int DepartmentID { get; set; }
        public int DepotID { get; set; }
        public string JobProfile { get; set; }
        public byte Active { get; set; }
    }
}
