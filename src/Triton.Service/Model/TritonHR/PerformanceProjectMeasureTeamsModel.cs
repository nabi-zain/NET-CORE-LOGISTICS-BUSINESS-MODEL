using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceProjectMeasureTeams")]
    public class PerformanceProjectMeasureTeamsModel
    {
       [Dapper.Contrib.Extensions.Key]
        public int ProjectMeasureTeamID { get; set; }
        public int ProjectMeasureID { get; set; }
        public int TeamID { get; set; }

        //Additional Fields
        [DisplayName("Team Name")]
        [Write(false)]
        public string TeamName { get; set; }
       
        [DisplayName("Project Measure Name")]
        [Write(false)]
        public string ProjectMeasureName { get; set; }

        public DateTime Createdon { get; set; }
        public int Createdby { get; set; }
        public bool Active { get; set; }
    }
}
