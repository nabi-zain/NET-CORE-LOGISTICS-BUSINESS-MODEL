using System;
using System.Collections.Generic;
using System.Text;
using Triton.Service.Model.CRM.Tables;

namespace Triton.Service.Model.CRM.Custom
{
    public class CustomerReportModel
    {
        public string CustomerReportText { get; set; }
        public List<CustomerReport> CustomerReportList { get; set; }
        public CustomerReport CustomerReport { get; set; }
    }
}
