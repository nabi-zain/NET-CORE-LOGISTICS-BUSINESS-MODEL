using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.Applications.Custom
{
   public class tblExchangeRatesModels
    {

      public  tblExchangeRates ExchangeRates { get; set; }

    public Countrys Country { get; set; }
    }
}
