using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.CRM.Custom
{
    public class BranchSizeMapModel
    {
        public BranchSizeMap BranchSizeMap { get; set; }
        public BranchSizes BranchSizes { get; set; }
        public Branches Branches { get; set; }
    }
}
