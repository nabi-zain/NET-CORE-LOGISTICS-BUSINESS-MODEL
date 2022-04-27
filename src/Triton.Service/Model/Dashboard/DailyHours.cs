using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Dashboard
{
    public class DailyHours
    {
        public DateTime FirstOn { get; set; }
        public DateTime LastOff { get; set; }
        public string PayCode { get; set; }
        public string Day { get; set; }
        public string OvertimeHours { get; set; }
        public int tothrs { get; set; }
        public int totmin { get; set; }
    }
}
