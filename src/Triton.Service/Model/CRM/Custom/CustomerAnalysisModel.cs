using System.Collections.Generic;
using Triton.Model.CRM.Tables;

namespace Triton.Service.Model.CRM.Custom
{
    public class CustomerAnalysisModel
    {
        public List<CustomerAnalysis> CustomerAnalysis { get; set; }
        public int RateIncreaseID { get; set; }
        public int UserID { get; set; }
        public string RateIncreasePeriod { get; set; }
    }
}
