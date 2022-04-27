using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    public class PerformanceEmployeeModel
    {
        [Key]
        public int Employeeid { get; set; }
        public string Currentemployeecode { get; set; }
        public string Initials { get; set; }
        public string Fullnames { get; set; }
        public string Surname { get; set; }
        public string LongName { get; set; }
    }
}
