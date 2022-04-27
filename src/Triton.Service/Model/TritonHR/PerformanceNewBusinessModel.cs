using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceNewBusinessRevenueDownload")]
    public class PerformanceNewBusinessModel
    {
        public int TeamID { get; set; }
        public int? EmployeeID { get; set; }
        public string CurrentEmployeeCode { get; set; }
        public string LeaveDisplayName { get; set; }
        public decimal FreightValue { get; set; }
        [Write(false)]
        public decimal Target { get; set; }
        public string Financial_MonthName { get; set; }
        public DateTime DateStamp { get; set; }
        public int? OutputMeasureID { get; set; }
    }
}
