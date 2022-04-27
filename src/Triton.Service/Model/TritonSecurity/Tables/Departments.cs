using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Departments")]
    public class Departments
    {
        [Key]
      public int DepartmentID { get; set; }
        public string Department { get; set; }
        public int PrimaryManagerID { get; set; }
        public int SecondaryManagerID { get; set; }
        public bool PrimaryActive { get; set; }
        public bool DepartmentActive { get; set; }
    }
}
