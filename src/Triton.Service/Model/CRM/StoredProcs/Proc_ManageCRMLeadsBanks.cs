using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class Proc_ManageCRMLeadsBanks
    {
        public string CompanyName { get; set; }
        public string Stage { get; set; }
        public string BranchFullName { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime FilterDate { get; set; }
        public string EstExp { get; set; }
        public string ContactNumber { get; set; }
        public string Location { get; set; }


    }
}
