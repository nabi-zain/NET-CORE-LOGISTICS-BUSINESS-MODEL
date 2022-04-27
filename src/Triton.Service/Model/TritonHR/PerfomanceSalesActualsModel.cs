using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceActualsTargetsDownloads")]
    public class PerfomanceSalesActualsModel
    {
        public int TeamID { get; set; }
        public int EmployeeID { get; set;}
        public string CurrentEmployeeCode { get; set; }
        public string Name { get; set; }
        public decimal FreightValue { get; set; }
        public decimal Target { get; set; }
        public DateTime MonthFor { get; set; }
        public string MonthName { get; set; }
        public int OutputMeasureID { get; set; }

    }
}
