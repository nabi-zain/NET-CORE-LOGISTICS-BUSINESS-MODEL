using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Table("PerformanceTeamOutputMeasure")]
    public class PerformanceTeamOutputMeasures
    {
        [Dapper.Contrib.Extensions.Key]
        public int TeamOutputMeasureID { get; set; }

        [DisplayName("Team")]
        public int TeamID { get; set; }

        [DisplayName("Output Measure Period")]
        public int PeriodID { get; set; }

        public int OutputMeasureID { get; set; }
        public int Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public bool Active { get; set; }

        //Addtional Fields
        [DisplayName("Team Name")]
        [Write(false)]
        public string TeamName { get; set; }

        [DisplayName("Output Measure Name")]
        [Write(false)]
        public string OutputMeasurename { get; set; }

        [DisplayName("Period")]
        [Write(false)]
        public string PeriodName { get; set; }

    }
}
