using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Dashboard
{
    public class HRMExceptionsModel
    {
        public int ReportException { get; set; }
        public string ExceptionName { get; set; }
        public int BranchID { get; set; }
        public string BranchFullName { get; set; }
        public int DepartmentID { get; set; }
        public int Total { get; set; }
        public string URL { get; set; }
        public string AdditionalCommand { get; set; }
    }
}
