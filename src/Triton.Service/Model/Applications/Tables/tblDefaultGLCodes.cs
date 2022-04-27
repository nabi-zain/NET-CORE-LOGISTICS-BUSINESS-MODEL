using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
    
    {
     [Table("tblDefaultGLCodes")]
    public class tblDefaultGLCodes
    {

        [Dapper.Contrib.Extensions.Key]
        public int DefaultGLID { get; set; }

        [Required]
        public int GLCode { get; set; }

        [Required]
        public int POType { get; set; }
       
        
    }
}
