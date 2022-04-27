using System;

namespace Triton.Model.TritonOps.Tables
{
    public class CCLRoutesLeg
    {
        public int CCLRoutesLegID { get; set; }
        public string Routes { get; set; }
        public string Leg { get; set; }
        public string Trailer { get; set; }
        public int? CCLRouteID { get; set; }
        public int? TrailerLookUpCodeID { get; set; }
        public int? FromBranchID { get; set; }
        public int? ToBranchID { get; set; }
        public DateTime? TransitTime { get; set; }
        public DateTime? DepartureLegTime { get; set; }
        public DateTime? WaitingTime { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public int? AverageKm { get; set; }
    }
}
