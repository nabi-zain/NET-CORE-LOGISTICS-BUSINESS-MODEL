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
    [Table("PerformanceMeasureScale")]
    public class PerformanceMeasureScaleModel
    {
        [Dapper.Contrib.Extensions.Key]
        public  int MeasurescaleID { get; set; }
           [DisplayName("Output Measure")]
        public int OutputMeasureID { get; set; }
         [DisplayName("Rating")]
        public int RatingID { get; set; }
        [Range(-100, 2147483647)]
        [DisplayName("Minimun Value")]
        public  decimal Minvalue { get; set; }
        [Range(-100, 2147483647)]
        [DisplayName("Maximum Value")]
        public  decimal Maxvalue { get; set; }
        public  int Createdby { get; set; }
        public  DateTime Createdon { get; set; }
        public  bool Active { get; set; }
        //Additional Fields
        [DisplayName("Measure Name")]
        [Write(false)]
        public string MeasureName { get; set; }

        [DisplayName("Rating Description")]
        [Write(false)]
        public string RatingName { get; set; }

    }
}
