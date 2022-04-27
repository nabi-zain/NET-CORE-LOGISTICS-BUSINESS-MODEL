using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.CRM.Tables;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Service.Model.TritonSecurity.Custom
{
    public class RepUserModel
    {
        public RepCodes RepCodes { get; set; }
        public Employees Employees { get; set; }
        public orgOrganogram orgOrganogram { get; set; }
        public CostCentres CostCentres { get; set; }
    }
}
