using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceCustomerVisitDownload")]
    public class PerformanceCustomerVisitsModel
    {

        public int TeamID { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public string CurrentEmployeeCode { get; set; }
        public string purpose { get; set; }
        public int Visits { get; set; }
        [Write(false)]
        public decimal Target { get; set; }
        public DateTime DateOfMeeting { get; set; }
        public string MonthName { get; set; }
        public int? OutputMeasureID { get; set; }

        
    }
}
