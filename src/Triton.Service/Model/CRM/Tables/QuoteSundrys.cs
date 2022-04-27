using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("QuoteSundrys")]
    public class QuoteSundrys
    {
        [Key]
        public int QuoteSudryID { get; set; }
        public int QuoteID { get; set; }
        public string SundryService { get; set; }
        public Decimal? SundryCharge { get; set; }
        public string SundryDescr { get; set; }
    }
}
