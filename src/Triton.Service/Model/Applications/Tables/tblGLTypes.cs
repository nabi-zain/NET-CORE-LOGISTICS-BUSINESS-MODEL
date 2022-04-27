using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.Applications.Tables
{
    [Table("tblGLTypes")]
    public class tblGLTypes
    {
      
        [Key]
     
        public  int GLTypeID  { get; set; }
       [DisplayName("GL Type")]
        public  int GLType { get; set; }
    }
}
