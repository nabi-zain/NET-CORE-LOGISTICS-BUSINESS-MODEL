using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("VipTransact")]
    public class VipTransact
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string Year { get; set; }
        public string MonthId { get; set; }
        public decimal? AlTaken { get; set; }
        public  decimal? SlTaken { get; set; }
        public decimal? FrTaken { get; set; }
        public  decimal? UnpaidTaken { get; set; }
        public bool? Match { get; set; }
    }
}
