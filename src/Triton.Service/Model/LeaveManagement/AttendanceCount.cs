using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.LeaveManagement
{
    public class AttendanceCount
    {
        public int JobProfileId { get; set; }
        public string Description { get; set; }
        public int PostCount { get; set; }
        public int OnShift { get; set; }
        public int Late { get; set; }
    }
}
