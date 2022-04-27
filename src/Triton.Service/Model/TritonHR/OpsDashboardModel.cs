using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    public class OpsDashboardModel
    {
        public PerformanceteamModel Team { get; set; }
        public int OutputMeasureID { get; set; }
        public decimal ActualValue { get; set; }
        public decimal TargetValue { get; set; }
        public decimal Percentage { get; set; }
        //Additional Fields
        public string MonthName { get; set; }
        public PerformanceOutputMeasureModel OutputMeasureName { get; set; }
    }
}
