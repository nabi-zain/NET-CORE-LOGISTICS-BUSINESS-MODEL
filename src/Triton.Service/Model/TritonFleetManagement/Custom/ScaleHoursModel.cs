using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class ScaleHoursModel
    {
        public int ScaleHourID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int CostScaleHour { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public int DeletedByUserID { get; set; }
        public string JobProfileDescription { get; set; }
    }
}
