using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    public class PerformanceMeasureDataModel
    {
        [Key]
        public  int MeasuredataID { get; set; }
        public  int PerformancemeasureID { get; set; }
        public  int PerformanceteammemberID { get; set; }
        
        [Required(ErrorMessage = "Performance Value is required")]
        [Range(0, 2147483647)]
        public  int Value { get; set; }
        [StringLength(500)]
        public  string Description { get; set; }
        public  int Createdby { get; set; }
        public  DateTime Createdon { get; set; }
        public  bool Active { get; set; }
    }
}
