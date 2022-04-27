using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.NoCommerce.Custom
{
    public class BalanceModel
    {
        public bool wasSuccesfull { get; set; }
        public Decimal? Amount { get; set; }
        public string ErrorMsg { get; set; }
    }

    public class DepositModel
    {
        public bool wasSuccesfull { get; set; }
        public Decimal? Amount { get; set; }
        public string ErrorMsg { get; set; }
    }

    public class TransactionModel
    {
        public bool wasSuccesfull { get; set; }
        public Decimal? Amount { get; set; }
        public string ErrorMsg { get; set; }
    }

}
