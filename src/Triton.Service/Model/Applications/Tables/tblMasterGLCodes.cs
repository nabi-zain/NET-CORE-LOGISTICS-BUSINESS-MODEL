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
    [Table("tblMasterGLCodes")]
    public class tblMasterGLCodes
    {
       


        [Dapper.Contrib.Extensions.Key]
        public int GLCodeID { get; set; }
        
        [Required]
        public string GLCodeDescription { set; get; }
        
        [Required]
        public string GLCode { set; get; }

        [DisplayName("Status") ]
        [Required]
        public int StatusID { get; set; }
       
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime StatusDate { get; set; }
       
        [Required]
        public string GLType { set; get; }
       [DisplayName("Type")]

       
        public override string ToString()
        {
            return GLCodeDescription;
        }
       
        [Required]
        public  int CompanyID { get; set; }
    }

}

