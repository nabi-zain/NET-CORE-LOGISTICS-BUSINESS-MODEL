using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("JobGrades")]
    public class JobGrades
    {
        [Key] public int ID { get; set; }
        public string JobGradeCode { get; set; }
        public string JobGradeLongDescription { get; set; }
        public string JobGradeShortDescription { get; set; }
    }
}
