using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblVarianceFactors")]
     public class tblVarianceFactors
    {
        [Dapper.Contrib.Extensions.Key]
        public  int VarianceFactorID { get; set; }
      
           [Required]
           [DisplayName("VarianceFactor")]
        public  string VarianceFactor { get; set; }
 
        [Required]
        [DisplayName("Status")]
        public  int Status { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public  DateTime StatusDate { get; set; }
    

    }
}
