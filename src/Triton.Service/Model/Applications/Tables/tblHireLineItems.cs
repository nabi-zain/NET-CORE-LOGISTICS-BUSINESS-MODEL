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
    [Table("tblHireLineItems")]
    public class tblHireLineItems
    {
        [Dapper.Contrib.Extensions.Key]
        public int HireLineItemID { get; set; }

         [Required]
        public string HireDescription { get; set; }
       
        [Required]
        public int StatusID { set; get; }
        
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        [Required]
        public DateTime StatusDate { set; get; }
        
    }
}
