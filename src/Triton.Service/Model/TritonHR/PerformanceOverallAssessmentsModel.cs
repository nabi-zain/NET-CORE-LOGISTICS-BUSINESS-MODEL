using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Table("PerformanceOverallAssessments")]
    public class PerformanceOverallAssessmentsModel
    {
         [Dapper.Contrib.Extensions.Key]
        public int OverallAssessmentID { get; set; }
         public int EmployeeID { get; set; }
        public int OverallCatID { get; set; }
        public string Notes { get; set; }
        public int Createdby { get; set; }
        public DateTime Createdon { get; set; }

        //Additional Fields
        [DisplayName("Overall Category Name")]
        [Write(false)]
        public string OverallCategoryName { get; set; }
    }
}
