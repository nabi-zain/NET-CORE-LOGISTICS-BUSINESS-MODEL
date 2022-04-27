using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblLabourTypes")]
    public class tblLabourTypes
    {
        

        [Dapper.Contrib.Extensions.Key]
        [Required]
        public int LabourTypeID { set; get; }

         [Required]
        public string LabourType { get; set; }
         [Required]
       
        public int Status { set; get; }

      
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime StatusDate { set; get; }
    }
}
