using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DeliveriesSummary_DataRepository")]
    public class DeliveriesSummary_DataRepository
    {
        public int BranchID { get; set; }
        public string BranchName { get; set; }
        public string RouteName { get; set; }
        public string RouteDescription { get; set; }
        public int NumPassed { get; set; }
        public int NumFailed { get; set; }
        public DateTime DayFor { get; set; }
    }
}
