using System.Collections.Generic;
using Triton.Service.Model.TritonFleetManagement.Tables;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class CustomerModel
    {
        public Customer Customer { get; set; }
        public List<LookupCodeModel> LoyaltyStatus { get; set; }
        public List<LookupCodeModel> AccountStatusType { get; set; }
        public List<LookupCodeModel> CategoryType { get; set; }
        public int LookupcodeID { get; set; }
        public int SelectedLoyaltyStatus { get; set; }
        public int SelectedAccountStatusType { get; set; }
        public int SelectedCategoryType { get; set; }
        public string ErrorMessage { get; set; }
        public LookupCodeModel AccountStatusTypes { get; set; }
        public List<CompanyModel> CompanyModel { get; set; }
        public List<LookupCodeModel> LookupCodeModel { get; set; }
        public int SelectedCompany { get; set; }
        public CompanyModel Company { get; set; }
        public ContactTypeModel ContactTypes { get; set; }
        public List<LookupCodeModel> ContactTypeDetails { get; set; }
        public LookupCodeModel ContactTypeDetail { get; set; }
        public List<ContactType> ContactType { get; set; }
        public VendorCode VendorCode { get; set; }
        public List<VendorCode> VendorCodes { get; set; }
        public VendorCodeModel VendorCodeModel { get; set; }
        public List<LookupCodeModel> ITCType { get; set; }
        public DocumentRepository DocumentRepository { get; set; }
        public List<CustomerDocumentRepositoryModel> CustomerDocumentRepositoryList { get; set; }
        public CustomerDocumentRepositoryModel CountFiles { get; set; }
        public List<LookupCodeModel> LookupCodesPerCategory { get; set; }
    }
}
