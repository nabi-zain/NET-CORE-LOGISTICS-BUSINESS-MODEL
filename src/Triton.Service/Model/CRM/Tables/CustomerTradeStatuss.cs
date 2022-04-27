using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerTradeStatuss")]
    public class CustomerTradeStatuss
    {
        [Key]
        public int CustomerTradeStatusID { get; set; }
        public string CustomerTradeStatus { get; set; }
        public int SortOrder { get; set; }
        public string TradeSymbol { get; set; }
        public string Colour { get; set; }
    }
}
