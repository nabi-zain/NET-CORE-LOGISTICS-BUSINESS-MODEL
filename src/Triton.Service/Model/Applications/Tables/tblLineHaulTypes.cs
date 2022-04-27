using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblLineHaulTypes")]
    public class tblLineHaulTypes
    {
        [Dapper.Contrib.Extensions.Key]
        public int LineHaulTypeID { set; get; }
   
        [Required]
        public string LineHaulType { set; get; }

        [Required]
        public int Status { set; get; }
      
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime StatusDate { set; get; }
        

    }
}
