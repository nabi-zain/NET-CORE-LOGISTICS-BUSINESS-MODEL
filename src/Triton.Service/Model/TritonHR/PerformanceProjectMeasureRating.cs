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
    [Dapper.Contrib.Extensions.Table("PerformanceProjectMeasureRatings")]
    public class PerformanceProjectMeasureRating
    {
        [Dapper.Contrib.Extensions.Key]
        public int PerformanceProjectMeasureRatingID { get; set; }
        [DisplayName("Project Measure Name")]
        [Required(ErrorMessage = "Project Measure is required")]
        public int ProjectMeasureID { get; set; }
        [DisplayName("Project Measure Parameter")]
        [Required(ErrorMessage = "Project Measure Parameter is required")]
        public int ProjectMeasureParameterID { get; set; }
        [DisplayName("Project Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public int RatingID { get; set; }
        [DisplayName("Project Measure Rating Description")]
        [Required(ErrorMessage = "Rating Description is required")]
        public string RatingDescription { get; set; }

        public DateTime Createdon { get; set; }
        public int Createdby { get; set; }
        public bool Active { get; set; }

      //  public int Rating { get; set; }
         [DisplayName("Project Measure Name")]
         [Write(false)]
        public string ProjectMeasureName { get; set; }
         [DisplayName("Project Rating Parameter")]
         [Write(false)]
        public string ParameterName { get; set; }

    }
}
