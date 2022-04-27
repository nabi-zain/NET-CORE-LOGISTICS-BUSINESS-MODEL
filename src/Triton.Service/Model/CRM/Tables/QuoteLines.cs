using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("QuoteLines")]
    public class QuoteLines
    {
        [Key]
        public int QuoteLineID { get; set; }
        public int QuoteID { get; set; }
        public int Qty { get; set; }
        public string Mass { get; set; }
        public string ProdType { get; set; }
        public string Vol { get; set; }
        public string QuoteLineNo { get; set; }
        public string RateType { get; set; }
        public string VolWeight { get; set; }
        public string Length { get; set; }
        public string Breadth { get; set; }
        public string Height { get; set; }

        public string Description { get; set; }

        public Decimal? ChargeUnits { get; set; }
        public Decimal? Charge { get; set; }



    }
}
