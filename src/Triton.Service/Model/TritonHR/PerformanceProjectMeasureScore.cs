using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceProjectMeasure")]
    public class PerformanceProjectMeasureScore
    {
        [Dapper.Contrib.Extensions.Key]
        public int ProjectMeasureID { get; set; }
        [Required(ErrorMessage = "Output Measure is required")]
        public int OutputMeasureID { get; set; }
        [Required(ErrorMessage = " Appraisal Period is required")]
        public int PeriodID { get; set; }
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Rating Description is required")]
        public string RatingDescription { get; set; }
        public int ManagerScore { get; set; }
        public int EmployeeScore { get; set; }
        public decimal Aggregate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
