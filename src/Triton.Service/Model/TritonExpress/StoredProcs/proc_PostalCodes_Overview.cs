using System;

namespace Triton.Service.Model.TritonExpress.StoredProcs
{
    public class proc_PostalCodes_Overview
    {
        public int PostalCodeID { get; set; }
        public string PostalCode { get; set; }
        public string Name { get; set; }
        public string Suburb { get; set; }
        public string RateArea { get; set; }
        public int? RateAreaID { get; set; }
        public string BranchCode { get; set; }
        public string BayNo { get; set; }
        public string BayName { get; set; }
        public string BayRoute { get; set; }
        public string KnownAs { get; set; }
        public int? ServicedByLookUpCodeID { get; set; }
        public int? PostalCodeTransitTimeID { get; set; }
        public int? PostalCodeStatusID { get; set; }
        public int? ApprovalUserID { get; set; }
        public DateTime? ActionedOn { get; set; }
        public bool? Active { get; set; }
        public int? PostalCodeRequestID { get; set; }
        public int? KMsFromBranch { get; set; }
        public string ServicedBy { get; set; }
        public string ServiceDays { get; set; }
        public string ServiceBranch { get; set; }
    }
}
