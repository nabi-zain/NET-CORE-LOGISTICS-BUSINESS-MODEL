using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonHR
{
    [ Dapper.Contrib.Extensions.Table("PerformanceProjectMeasures")]
    public class PerformanceProjectMeasureModel
    {
        [Dapper.Contrib.Extensions.Key]
        public int ProjectMeasureID { get; set; }
                   
        [DisplayName("Project Measure Name")]
        [StringLength(150)]
        [Required(ErrorMessage = "Project Measure Name is required")]
        public string ProjectMeasureName { get; set; }
        [DisplayName("Project Measure Description")]
        [StringLength(500)]
        public string ProjectMeasureDesc { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
        public DateTime Createdon { get; set; }
        public int Createdby { get; set; }
        public bool Active { get; set; }
    }
}
