using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("QuoteAdditionals")]
    public class QuoteAdditionals
    {
        [Key]
        public int QuoteAdditionalID { get; set; }
        public int QuoteID { get; set; }
        public string AddService { get; set; }
        public Decimal? AddCharge { get; set; }
        public string AddDescr { get; set; }

    }
}
