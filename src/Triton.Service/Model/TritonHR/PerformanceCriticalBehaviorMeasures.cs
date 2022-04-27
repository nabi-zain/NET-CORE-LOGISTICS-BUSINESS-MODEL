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
    [Dapper.Contrib.Extensions.Table("PerformanceCriticalBehaviorMeasure")]
    public class PerformanceCriticalBehaviorMeasureModel
    {
       
        [Dapper.Contrib.Extensions.Key]
        public int CriticalBehaviorMeasureID { get; set; }
        public int CriticalBehaviorID { get; set; }

        [DisplayName("Critical Behavior Measure Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "Critical Behavior Measure Name is required")]
        public string CriticalBehaviorMeasureName { get; set; }
        public DateTime Createdon { get; set; }
        public int Createdby { get; set; }
        public bool Active { get; set; }

        //Additional Fields
        [DisplayName("Critical Behavior Name")]
        [Write(false)]
        public string CriticalBehaviorName { get; set; }
    }
}
