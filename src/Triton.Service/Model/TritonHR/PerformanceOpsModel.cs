using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceDataDownload")]
    public class PerformanceOpsModel
    {
       [Dapper.Contrib.Extensions.Key]
        public int ID { get; set; }
        public int TeamID { get; set; }
        public int OutputMeasureID { get; set; }
        public int EmployeeID { get; set; }
        public string CurrentEmployeeCode { get; set; }
        public int FieldMappingID { get; set; }
        public string EmployeeName { get; set; }
        public string MonthName { get; set; }
        public decimal Value { get; set; }
        public DateTime ForDate { get; set; }
    }
}
