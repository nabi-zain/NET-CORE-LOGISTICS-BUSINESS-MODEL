using System.Collections.Generic;
using Triton.Model.TritonExpress.Tables;
using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Service.Model.TritonExpress.Custom
{
    public class PostalCodesModel
    {
        public PostalCodes PostalCodes { get; set; }
        public List<PostalCodeTransitTime> PostalCodeTransitTime { get; set; }
        public List<PostalCodeStatus> PostalCodeStatus { get; set; }
        public List<LookUpCodes> Lookupcodes { get; set; }
        public List<Branches> Branches { get; set; }
        public int SelectedPostalCodeTransitTimeId { get; set; }
        public int SelectedPostalCodeStatusId { get; set; }
        public int SelectedLookupcodesId { get; set; }
        public string SelectedBranchCode { get; set; }
        public string ErrorMessage { get; set; }

    }
}
