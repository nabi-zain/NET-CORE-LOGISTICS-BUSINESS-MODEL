using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class Proc_ManageCRMAdjustmentBank
    {
        public string AccountCode { get; set; }
        public DateTime DateEffective { get; set; }
        public string BranchFullName { get; set; }
        public string RepName { get; set; }
        public string Description { get; set; }
        public byte HasUnique { get; set; }
        public byte Special { get; set; }
        public decimal SWAT { get; set; }
        public string FWRateAccCode { get; set; }
    }
}
