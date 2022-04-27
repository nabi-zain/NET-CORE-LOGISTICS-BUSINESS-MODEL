using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonGroup.Custom
{
    public class TaxRatesModel
    {
        public TaxRates TaxRate { get; set; }
        public Countrys Country { get; set; }
        public Triton.Model.TritonGroup.Tables.Users CreatedBy { get; set; }
        public Triton.Model.TritonGroup.Tables.Users DeletedBy { get; set; }
    }
}
