using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceSalesPipelineDownload")]
    public class PerformancePipelineValueModel
    {
        public int TeamID { get; set; }
        public int EmployeeID { get; set; }
        public string CurrentEmployeeCode { get; set; }
        public string SalesConsultant { get; set; }
        public decimal TotalExpectedMonthlyRevenue { get; set; }
        [Write(false)]
        public decimal Target { get; set; }
        public DateTime OpportunityEntered { get; set; }
        public string MonthName { get; set; }
        public int? OutputMeasureID { get; set; }
        public int OpportunityScore { get; set; }
    }
}
