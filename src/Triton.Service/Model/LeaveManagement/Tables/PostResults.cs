using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("POST_RESULTS")]
    public class PostResults
    {
        public string JobProfile { get; set; }
        public string JobCategory { get; set; }
        public int? CostCentreID { get; set; }
        public int? Skill { get; set; }
        public int? AuthTotal { get; set; }
        public int? FilledTotal { get; set; }
        public  int? VacantTotal { get; set; }
    }
}
