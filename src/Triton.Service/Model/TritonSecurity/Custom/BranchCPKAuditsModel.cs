using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.Custom
{
    public class BranchCPKAuditsModel
    {
        public BranchCPKAudits BranchCpkAudits { get; set; }
        public BranchCPKS BranchCpks { get; set; }
        public Branches Branches { get; set; }
    }
}
