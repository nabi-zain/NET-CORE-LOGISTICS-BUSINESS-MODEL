using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    public class PerformanceComplianceModel
    {
        public int EmployeeID { get; set; }
        public int FieldMappingID { get; set; }
        public decimal Value { get; set; }
        public DateTime ForDate { get; set; }
    }
}
