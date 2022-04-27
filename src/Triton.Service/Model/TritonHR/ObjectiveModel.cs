using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("Objective")]
    public class ObjectiveModel
    {
        [Dapper.Contrib.Extensions.Key]
        public  int Objectiveid { get; set; }
        public  int Teamid { get; set; }
        public  int periodid { get; set; }

        [DisplayName("Objective Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Objective Name is required")]
        public  string Objectivename { get; set; }
        [DisplayName("Objective Description (Max 500 Characters)")]
        [StringLength(500)]
        public  string Description { get; set; }
        public  DateTime Createdon { get; set; }
        public  int Createdby { get; set; }
        public  bool Active { get; set; }

        //Additional Fields
        [DisplayName("Team Name")]
        [Write(false)]
        public string TeamName { get; set; }

        [DisplayName("Period Name")]
        [Write(false)]
        public string PeriodName { get; set; }
    }
}
