using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class BookingsStatisticsModel
    {
        public int TotalBookings { get; set; }
        public int TodaysBookings { get; set; }
        public int YesterdaysBookings { get; set; }
        public int WeeklyBookings { get; set; }
        public int MonthlyBookings { get; set; }
        public int TodaysPerc { get; set; }
        public int YesterdaysPerc { get; set; }
        public int WeeklyPerc { get; set; }
    }
}
