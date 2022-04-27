using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("FuelSurchargeClassAudits")]
    public class FuelSurchargeClassAudits
    {
        [Key]
        public int FuelSurchargeClassAuditID { get; set; }
        public int FuelSurchargeClassID { get; set; }
        public  string Code { get; set; }
        public  string Description { get; set; }
        public  decimal? CurrentValue { get; set; }
        public  decimal? MinumumValue { get; set; }
        public  DateTime? MonthValid { get; set; }
    }
}
