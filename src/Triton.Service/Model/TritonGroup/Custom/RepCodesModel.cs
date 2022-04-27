namespace Triton.Service.Model.TritonGroup.Custom
{
    public class RepCodesModel
    {
        public int RepCodeID { get; set; }
        public int UserID { get; set; }
        public string RepCode { get; set; }
        public byte Active { get; set; }
        public byte ActiveCommision { get; set; }
        public byte ServiceRep { get; set; }
        public string AlternateName { get; set; }
        public string AlternateBranchCode { get; set; }
        public int AlternateOrderBy { get; set; }
        public string NamesAndSurname { get; set; }
    }
}
