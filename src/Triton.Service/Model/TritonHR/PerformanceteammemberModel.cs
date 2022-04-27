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
    [Table("PerformanceTeamMember")]
    public class PerformanceteammemberModel
    {
        [Dapper.Contrib.Extensions.Key]
        [Computed]
        public  int TeammemberID { get; set; }
        public  int TeamID { get; set; }
        [Required(ErrorMessage = "Employee Code is required")]
        public  string Employeecode { get; set; }
        [Computed]
        public int? EmployeeID { get; set; }
        public  int Createdby { get; set; }
        public  DateTime Createdon { get; set; }
        public  bool Active { get; set; }

        //Additional Fields
        [DisplayName("Team Name")]
        [Write(false)]
        [Computed]
        public string TeamName { get; set; }
        
        [DisplayName("Team Member Name")]
        [Write(false)]
        [Computed]
        public string MemberName { get; set; }
    }
}
