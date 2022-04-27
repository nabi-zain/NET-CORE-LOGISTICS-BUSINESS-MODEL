using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceProjectMeasureTeamMembers")]
    public class PerformanceProjectMeasureTeamMembersModel
    {
        [Dapper.Contrib.Extensions.Key]
        public int ProjectMeasureTeamMemberID { get; set; }
         [DisplayName("Project Measure")]
        public int ProjectMeasureID { get; set; }
         [DisplayName("Team Member")]
        public int TeamMemberID { get; set; }

        [DisplayName("Team Member Name")]
        [Write(false)]
        public string MemberName { get; set; }

        [DisplayName("Project Measure Name")]
        [Write(false)]
        public string ProjectMeasureName { get; set; }

        public DateTime Createdon { get; set; }
        public int Createdby { get; set; }
        public bool Active { get; set; }
    }
}
