using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("StaffLimit")]
    public class StaffLimit
    {
        [Key]
        public int ID { get; set; }
        public int? CostcentreID { get; set; }
        public int? DepartmentID { get; set; }
        public int? GroupID { get; set; }
        public int? Limit { get; set; }
    }
}
