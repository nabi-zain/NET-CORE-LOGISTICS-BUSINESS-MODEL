using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;


namespace Triton.Model.TritonHR
{
    [Table("PerformanceTarget")]
    public class PerformanceTargetModel
    {
        [Dapper.Contrib.Extensions.Key]       
        public  int TargetID { get; set; }
        public  int MeasureID { get; set; }
        public  int PeriodID { get; set; }
        [Range(0, 2147483647)]
        [Required(ErrorMessage = "Target Value is required")]
        public  int Targetvalue { get; set; }
         [StringLength(50)]
        [Required(ErrorMessage = "Target Name is required")]
        public  string Targetname { get; set; }
        public  int Createdby { get; set; }
        public  DateTime Createdon { get; set; }
        public  bool Active { get; set; }

        //Additional Fields
        [DisplayName("Measure Name")]
        [Write(false)]
        public string MeasureName { get; set; }

        [DisplayName("Period Name")]
        [Write(false)]
        public string PeriodName { get; set; }
    }
}
