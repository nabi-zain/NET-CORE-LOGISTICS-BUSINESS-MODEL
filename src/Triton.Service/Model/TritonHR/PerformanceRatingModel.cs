using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
   [Table("PerformanceRating")]
    public class PerformanceRatingModel
    {
        [Dapper.Contrib.Extensions.Key]
        public  int Ratingid { get; set; }
        [Range(0, 5)]
        [Required(ErrorMessage = "Rating is required")]
        public  int Rating { get; set; }
        [Required(ErrorMessage = "Rating description is required")]
        [StringLength(50)]
        public  string Ratingdesc { get; set; }
        public int Createdby { get; set; }
        public DateTime Createdon { get; set; }
        public bool Active { get; set; }
    }
}
