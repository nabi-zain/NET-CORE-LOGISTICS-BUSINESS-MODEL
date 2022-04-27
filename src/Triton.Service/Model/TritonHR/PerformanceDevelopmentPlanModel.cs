using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model
{
    [Dapper.Contrib.Extensions.Table("PerformanceDevelopmentPlan")]
    public class PerformanceDevelopmentPlanModel
    {
        [Dapper.Contrib.Extensions.Key]
        public int DevelopmentPlanID { get; set; }
        public int EmployeeID { get; set; }
        [DisplayName("Action")]
        [StringLength(100)]
        [Required(ErrorMessage = "Action is required")]
        public string Action { get; set; }
       
        [DisplayName("Due Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Due Date is required")]
        public DateTime DueDate { get; set; }

        public DateTime Createdon { get; set; }
        public int Createdby { get; set; }
        public bool Active { get; set; }
    }
}
