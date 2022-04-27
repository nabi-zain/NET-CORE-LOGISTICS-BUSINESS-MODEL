using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceCriticalBehaviorMeasureScore")]
    public class PerformanceCriticalBehaviorMeasureScoreModel
    {
        [Dapper.Contrib.Extensions.Key]
        public int CriticalBehaviorMeasureScoreID { get; set; }
        public int CriticalBehaviorMeasureID { get; set; }
        public int EmployeeID { get; set; }
        public int AppraisalPeriodID { get; set; }
         [DisplayName("Manager")]
        public decimal ManagerScore { get; set; }
         [DisplayName("Self")]
        public decimal EmployeeScore { get; set; }
           [DisplayName("Rating Applied")]
        public decimal AggregateScore { get; set; }

        //Additional Fields
        [DisplayName("Critical Behavior Name")]
        [Write(false)]
        public string CriticalBehaviorName { get; set; }

        //Additional Fields
        [DisplayName("Critical Behavior Name")]
        [Write(false)]
        public string CriticalBehaviorMeasureName { get; set; }
        public int Createdby { get; set; }
        public DateTime Createdon { get; set; }

    }
}
