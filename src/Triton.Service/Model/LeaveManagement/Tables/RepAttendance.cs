using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("RepAttendance")]
    public class RepAttendance
    {
        [Key]
        public int AttID { get; set; }
        public string EmpCode { get; set; }
        public string FirstNames { get; set; }
        public string Initials { get; set; }
        public string LastName { get; set; }
        public int? EmployeeID { get; set; }
        public string Post { get; set; }
        public DateTime? WorkDate { get; set; }
        public DateTime? FirstOn { get; set; }
        public DateTime? LastOff { get; set; }
        public DateTime? ShiftStartTime { get; set; }
        public DateTime? ShiftEndTime { get; set; }
        public string Shift { get; set; }
        public string Department { get; set; }
        public string CostCentre { get; set; }
        public string StartStatus { get; set; }
        public string EndStatus { get; set; }
        public int? PreShift { get; set; }
        public int? PostShift { get; set; }
        public int? DepartmentID { get; set; }
        public int? CostCentreID { get; set; }
    }
}
