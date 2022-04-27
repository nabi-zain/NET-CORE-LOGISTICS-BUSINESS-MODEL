using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Table("PerformancePeriod")]
    public class PerformanceperiodModel
    {
        [Dapper.Contrib.Extensions.Key]
        public  int Periodid { get; set; }
        [Required(ErrorMessage = "Period name is required")]
        [StringLength(50)]
        public  string Periodname { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Period start date is required")]
        public  DateTime Periodstartdate { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Period end date is required")]
        public  DateTime Periodenddate { get; set; }

        public  int Createdby { get; set; }
        public  DateTime Createdon { get; set; }
        public  bool Active { get; set; }

        //Additional Fields
        [Write(false)]
        public bool Weekly { get; set; }
        [Write(false)]
        public bool Quarterly { get; set; }
        [Write(false)]
        public bool Monthly { get; set; }
      
    }
}
