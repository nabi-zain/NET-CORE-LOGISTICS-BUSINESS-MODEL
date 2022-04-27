using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceCriticalBehavior")]
    public class PerformanceCriticalBehaviorModel
    {
       
        [Dapper.Contrib.Extensions.Key]
        public int CriticalBehaviorID { get; set; }

        [DisplayName("Critical Behavior Name")]
        [StringLength(100)]
        [Required(ErrorMessage = "Critical Behavior Name is required")]
        public string CriticalBehaviorName { get; set; }
        public string CriticalBehaviorDesc { get; set; }
        public DateTime Createdon { get; set; }
        public int Createdby { get; set; }
        public bool Active { get; set; }

    }
}
