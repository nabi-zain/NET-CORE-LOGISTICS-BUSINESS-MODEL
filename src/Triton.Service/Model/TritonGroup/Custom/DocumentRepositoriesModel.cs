using Triton.Model.TritonGroup.Tables;

namespace Triton.Model.TritonGroup.Custom
{
    public class DocumentRepositoriesWithLookupCodes
    {
        public DocumentRepositories DocumentRepositories { get; set; }
        public LookUpCodes LookUpCodes { get; set; }
    }

    public class TLHImageWithRouting
    {
        public Triton.Model.TritonLH.Tables.TripDelivery Trip { get; set; }

        public Triton.Model.TritonLH.Tables.TripNames TripName { get; set; }

        public DocumentRepositories TLHImageRepository { get; set; }

        public LookUpCodes LookUpCodes { get; set; }
    }
}
