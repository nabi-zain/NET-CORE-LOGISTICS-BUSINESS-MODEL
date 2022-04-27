using System;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
    {
    [Table("tblDepartment")]
    public class tblDepartments
    {
             [Dapper.Contrib.Extensions.Key]
            public int DepartmentID { get; set; }

               [Required]
            public string Department { get; set; }
         
           [Required]
             [DisplayName("Primary Manager")]
            public int PrimaryManagerID { get; set; }
              [Required]
            [DisplayName("SecondaryManager")]
          
            public int SecondaryManagerID { get; set; }
           
            public  bool PrimaryActive { get; set; }

    }

    }
    
