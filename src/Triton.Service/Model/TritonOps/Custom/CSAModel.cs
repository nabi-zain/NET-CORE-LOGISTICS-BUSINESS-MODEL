using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonOps.Custom
{
    public class CSAModel
    {
        public CSA CSA { get; set; }
        public Users Users { get; set; }
    }
}
