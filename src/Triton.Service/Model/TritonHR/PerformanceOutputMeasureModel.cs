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
    [Table("PerformanceOutputMeasure")]
    public class PerformanceOutputMeasureModel
    {
        [Dapper.Contrib.Extensions.Key]
        public  int OutputMeasureID { get; set; }

       
        [DisplayName("Output Measure Aggregate")]
        public int AggregateID { get; set; }

        [DisplayName("Output Measure Name")]
        [Required(ErrorMessage = "Measure name is required")]
        [StringLength(80)]
        public  string OutputMeasurename { get; set; }

        [DisplayName("Output Measure Description (Max 150 Characters)")]
        [StringLength(150)]
        public  string OutputMeasuredesc { get; set; }

        [DisplayName("Target Value")]
        [Required(ErrorMessage = "Target value is required")]
        [Range(0.0, Double.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal OutputTarget { get; set; }

        [DisplayName("Weight %")]
        [Required(ErrorMessage = "Weighing is required")]
        [Range(0.0, Double.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:n0}")]
        public decimal OutputWeight { get; set; }

        public  int Createdby { get; set; }
        public  DateTime Createdon { get; set; }
        public  bool Active { get; set; }

        //Addtional Fields
        [DisplayName("Team Name")]
        [Write(false)]
        public string TeamName { get; set; }

        [DisplayName("Aggregate Name")]
        [Write(false)]
        public string AggregateName { get; set; }

        [DisplayName("Period")]
        [Write(false)]
        public string PeriodName { get; set; }
    }
}
