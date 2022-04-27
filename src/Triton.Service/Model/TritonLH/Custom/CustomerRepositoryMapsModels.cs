using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class CustomerRepositoryMaps_DocumentRepository
    {
        #region Properties

        public CustomerRepositoryMaps CustomerRepositoryMaps { get; set; }

        public DocumentRepositories DocumentRepositories { get; set; }
        public LookUpCodes LookUpCode { get; set; }

        #endregion Properties
    }
}