using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_RepsActiveCustomersPerCycle_Select
    {
        public string RateCyclesDescription { get; set; }
        public string ShortDescription { get; set; }
        public int CustomerID { get; set; }
        public string AccountCode { get; set; }
        public string CompanyName { get; set; }
        public string RateClassDescription { get; set; }
        public string FWRepCode { get; set; }
        public string RepName { get; set; }
        public bool IsChecked { get; set; } = true;
    }
}
