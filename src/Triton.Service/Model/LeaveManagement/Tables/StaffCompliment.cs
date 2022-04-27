using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("StaffCompliment")]
    public class StaffCompliment
    {
        public int ID { get; set; }
        public int JobProfileID { get; set; }
        public int CostCentreID { get; set; }
        public int Authorised { get; set; }
        public int Actual { get; set; }
    }
}
