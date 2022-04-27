using System.Collections.Generic;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class CompanyModel
    {
        public int CompanyID { get; set; }
        public string Description { get; set; }
        public string VatNo { get; set; }
        public string Contact { get; set; }
        public string ContacNumber { get; set; }
        public string RegNo { get; set; }
        public string ShortCompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public string BulkEmailAddress { get; set; }
        public string HasVehicle { get; set; }
        public List<Companys> company { get; set; }
    }
}
