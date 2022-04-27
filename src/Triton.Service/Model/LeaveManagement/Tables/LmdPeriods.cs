using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("LmdPeriods")]
    public class LmdPeriods
    {
        [Key]
        public int ID { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string Year { get; set; }
        public int? MonthiD { get; set; }
    }
}
