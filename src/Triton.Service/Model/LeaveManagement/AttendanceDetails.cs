using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.LeaveManagement
{
    public class AttendanceDetails
    {
        public int EmployeeID { get; set; }
         [DisplayName("Employee Code")]
        public string CurrentEmployeeCode { get; set; }
         [DisplayName("Job Title")]
        public string JobProfile { get; set; }
         [DisplayName("Employee Names")]
        public string DisplayName { get; set; }
         [DisplayName("Date")]
        public DateTime StartDateTime { get; set; }
         [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }

        public DateTime FirstOn { get; set; }
        public string Notes { get; set; }
    }
}
