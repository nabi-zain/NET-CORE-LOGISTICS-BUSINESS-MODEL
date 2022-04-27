using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    public class PerformanceCustomerVisitsTeamDashboard
    {
        public PerformanceteammemberModel TeamMember { get; set; }
        public int OutputMeasureID { get; set; }
        public int ActualValue { get; set; }
        public int TargetValue { get; set; }
        //Additional Fields
        public string MonthName { get; set; }
        public PerformanceOutputMeasureModel OutputMeasureName { get; set; }
    }
}
