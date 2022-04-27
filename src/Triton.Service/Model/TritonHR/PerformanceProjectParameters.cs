using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Dapper.Contrib.Extensions.Table("PerformanceProjectMeasureParameters")]
    public class PerformanceProjectParameters
    {
        [Dapper.Contrib.Extensions.Key]
        public int ProjectMeasureParameterID { get; set; }
        [DisplayName("Project Measure Parameter")]
        [Required(ErrorMessage = "Project Measure Rating Parameter is required")]
        public string ParameterName { get; set; }
    }
}
