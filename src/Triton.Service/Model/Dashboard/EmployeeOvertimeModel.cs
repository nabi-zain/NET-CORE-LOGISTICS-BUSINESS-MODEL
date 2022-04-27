using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Dashboard
{
    public class EmployeeOvertimeModel
    {
        public int EmployeeID { get; set; }
        public string Empcode { get; set; }
        public string FirstNames { get; set; }
        public string LastName { get; set; }
        public string Post { get; set; }
        public int CostCentreID { get; set; }
        public DateTime Date { get; set; }
        public DateTime FirstOn { get; set; }
        public DateTime LastOff { get; set; }
        public string Time { get; set; }
        public string SHIFT { get; set; }
        public string PayCode { get; set; }
        public int TotalOvertimeSeconds { get; set; }
        public string BranchFullName { get; set; }
        public int? TotalWeeklyHours { get; set; }
        public int? TotalWeeklyMinutes { get; set; }
        public int OvertimeInSeconds { get; set; }
        public string Route { get; set; }   
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public List<DailyHours> DayOvertimeHours { get; set; }
         [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public List<Routes> DayRoutes { get; set; }
    }
}
