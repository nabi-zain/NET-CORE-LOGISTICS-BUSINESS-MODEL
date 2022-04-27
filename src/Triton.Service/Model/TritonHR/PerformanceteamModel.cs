using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Table("PerformanceTeam")]
    public class PerformanceteamModel
    {
        [Dapper.Contrib.Extensions.Key]
        public  int Teamid { get; set; }

        [Required(ErrorMessage = "Team name is required")]
        public  string Teamname { get; set; }
        [Required(ErrorMessage = "Team Manager is required")]
        public  int Managerorgid { get; set; }
        public  int Createdby { get; set; }
        public  DateTime Createdon { get; set; }
        public  bool Active { get; set; }

        //Additional Fields
        [DisplayName("Team Manager")]
        [Write(false)]
        public string Managername { get; set; }
        [DisplayName("Branch Name")]
        [Write(false)]
        public string BranchFullName { get; set; }
        [DisplayName("Branch Name")]
        public int CostCentreId { get; set; }
        [DisplayName("Created By")]
        [Write(false)]
        public string CreatedByName { get; set; }
        public string KnownAs { get; set; }
         [DisplayName("Ops Team Level")]
        public int OpsLevelID { get; set; }

        [Write(false)]
        List<PerformanceteammemberModel> TeamMembers { get; set; }
    }
}
