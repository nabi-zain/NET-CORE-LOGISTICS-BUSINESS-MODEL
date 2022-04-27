using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("FinancialTargets")]
    public class FinancialTargets
    {
        [Key]
        public  int FinancialTargetID { get; set; }
        public  decimal? Target { get; set; }
        public  int? FinancialYear { get; set; }
        public  int? FinancialMonth { get; set; }
    }
}
