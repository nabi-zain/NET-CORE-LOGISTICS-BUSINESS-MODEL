using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Dashboard
{
    public class EmployeeJobProfileOvertimeModel
    {
        public string Post { get; set; }
          [DisplayName("No of Employees")]
        public int OvertimeCount { get; set; }
        public int HighOvertimeCount { get; set; }
        public int PreviousDayOvertimeCount { get; set; }
       
    }
}
