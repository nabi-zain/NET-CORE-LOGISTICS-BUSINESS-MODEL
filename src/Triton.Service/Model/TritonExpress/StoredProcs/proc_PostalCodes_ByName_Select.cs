using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonExpress.StoredProcs
{
    public class proc_PostalCodes_ByName_Select
    {
        public int PostalCodeID { get; set; }
        public string PostalCOde { get; set; }
        public string Name { get; set; }
        public string Suburb { get; set; }
        public string RateArea { get; set; }
        public int RateAreaID { get; set; }
        public string BranchCode { get; set; }
        public string BayNo { get; set; }
        public string BayName { get; set; }
        public string BayRoute { get; set; }
        public string KnownAs { get; set; }
        public int ServiceByLookUpCodeID { get; set; }
        [Column( "PostalCode Transit TimeID ")]
        public int PostalCodeTransitTimeID { get; set; }
        public int PostalCodeStatusID { get; set; }
        public int ApprovalUserID { get; set; }
        public byte Active { get; set; }
        public int PostalCodeRequestID { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string DistanceFromBranch { get; set; }
        public string TransitTime { get; set; }
        public string ServicedBy { get; set; }
        public string BranchFullName { get; set; }
        public string RateAreaBRanch { get; set; }
        public string BranchAlias { get; set; }
    }
}
