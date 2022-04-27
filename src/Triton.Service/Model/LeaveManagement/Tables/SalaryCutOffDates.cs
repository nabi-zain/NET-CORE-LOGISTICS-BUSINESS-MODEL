using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("SalaryCutOffDates")]
    public class SalaryCutOffDates
    {
        [Key]
        public int CutOffID { get; set; }
        public int CutOffYear { get; set; }
        public string CutOffMonth { get; set; }
        public DateTime CutOffFromDate { get; set; }
        public DateTime CutOffToDate { get; set; }
    }
}
