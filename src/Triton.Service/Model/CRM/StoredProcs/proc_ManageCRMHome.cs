using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_ManageCRMHome
    {
        public int GlobalRank { get; set; }
        public string AccountCode { get; set; }
        public string Customer { get; set; }
        public string Vertical { get; set; }
        public byte visted { get; set; }
        public string BranchFullName { get; set; }
        public decimal AmountTraded { get; set; }
        public decimal FreightBilling { get; set;}
        public decimal SWAT { get; set; }
    }
}
