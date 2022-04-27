using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonExpress.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CustomerAdditionalContactsService
    {
        public static async Task<long> InsertCustomerAdditionalContactsAsync(CustomerAdditionalContacts model)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.CustomerAdditionalContacts}InsertCustomerAdditionalContactsAsync/Insert"), model);
        }

        public static async Task<bool> UpdateCustomerAdditionalContactsAsync(CustomerAdditionalContacts model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.CustomerAdditionalContacts}UpdateCustomerAdditionalContactsAsync/Update"), model);
        }

        public static async Task<bool> DeleteCustomerAdditionalContactsAsync(int customerAdditionalContactID, int userID)
        {
            return await RestApiHelper.DeleteAsync(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.CustomerAdditionalContacts}DeleteCustomerAdditionalContactsAsync/{customerAdditionalContactID}/{userID}"));
        }

        public static async Task<List<CustomerAdditionalContacts>> GetCustomerAdditionalContactsByAccountCode(string accountCode)
        {
            return await RestApiHelper.GetAsync<List<CustomerAdditionalContacts>>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.CustomerAdditionalContacts}GetCustomerAdditionalContactsByAccountCode/{accountCode}"));
        }

        public static async Task<List<CustomerAdditionalContacts>> GetCustomerAdditionalContactsByCustomerID(int customerID)
        {
            return await RestApiHelper.GetAsync<List<CustomerAdditionalContacts>>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.CustomerAdditionalContacts}GetCustomerAdditionalContactsByCustomerID/{customerID}"));
        }

        public static async Task<CustomerAdditionalContacts> GetCustomerAdditionalContactsByID(int customerAdditionalContactID)
        {
            return await RestApiHelper.GetAsync<CustomerAdditionalContacts>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.CustomerAdditionalContacts}GetCustomerAdditionalContactsByID/{customerAdditionalContactID}"));
        }

        public static async Task<List<LookUpCodes>> GetLookUpCodesByCategoryID(int lookUpCategorID)
        {
            return await RestApiHelper.GetAsync<List<LookUpCodes>>(new Uri(UrlHelper.Api.TritonApiLegacy, $"{UrlHelper.Controller.LookUpcodes}GetLookUpCodesByCategoryID?LookupcodeCategoryID={lookUpCategorID}"));
        }

        public static async Task<CustomerAdditionalContacts> GetCustomerAdditionalEmailCellTelByID(string Cell, string Tel, string Email, int CustomerID)
        {
            return await RestApiHelper.GetAsync<CustomerAdditionalContacts>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.CustomerAdditionalContacts}GetCustomerAdditionalEmailCellTelByID/{Cell}/{Tel}/{Email}/{CustomerID}"));
        }
    }
}
