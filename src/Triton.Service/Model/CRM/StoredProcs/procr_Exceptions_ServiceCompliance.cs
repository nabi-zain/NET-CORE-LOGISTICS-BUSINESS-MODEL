using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class procr_Exceptions_ServiceCompliance
    {
        public int ID { get; set; }

        public int? ReportException { get; set; }

        public int? BranchID { get; set; }

        public int? DepartmentID { get; set; }

        public decimal? Total { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}