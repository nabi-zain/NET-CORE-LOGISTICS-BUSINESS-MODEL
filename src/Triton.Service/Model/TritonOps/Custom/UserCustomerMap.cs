using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Model.TritonOps.Custom
{
    public class UserCustomerMap
    {
        public TritonGroup.Tables.Users Users { get; set; }
        public CRM.Tables.Customers Customers { get; set; }

        public TritonOps.Views.Vw_CSAReps Vw_CSA { get; set; }
    }
}
