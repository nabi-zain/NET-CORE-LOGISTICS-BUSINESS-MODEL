using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Triton.Model.Applications.Custom;

namespace Triton.Model.Applications.Tables
{
    [Table("tblExchangeRateMonthly")]
    public class tblExchangeRateMonthly
    { 
        public int ExchangeRateID { get; set; }
        public int CountryID { get; set; }

        
        public int MonthID { get; set; }
        
        [DisplayName("Exchange Rate TO Rand")]
        public decimal ExchangeRateToRandID { get; set; }
        
    }
}
