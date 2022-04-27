using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.CRM.Custom
{
    public class BillingModel
    {
        public string AccountCode { get; set; }
        public string Branch { get; set; }
        public string AccountType { get; set; }
        public string Rep { get; set; }
        public string RateClass { get; set; }
        public string VolRatio { get; set; }
        public string VerticalMarket { get; set; }
        public string SpecialArrangements { get; set; }
        public string SalesPeriod { get; set; }
        public string SaleType { get; set; }
        public DateTime LastIncrease { get; set; }
        public DateTime NextIncrease { get; set; }
        public string OpenedDate { get; set; }
        public string AccountAge { get; set; }
        public string CurrentSWAT  { get; set; }
        public string Insurance { get; set; }
        public string SubVertical { get; set; }
        public string Market { get; set; }
        public bool MarkForClosure { get; set; }
        public string HasUniques { get; set; }
        public string NewBusiness { get; set; }
        public string FuelSurcharge { get; set; }
    }
}
