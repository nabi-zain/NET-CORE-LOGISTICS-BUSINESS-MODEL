using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Model.TritonFleetManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CustomerRatesService
    {
        public static async Task<List<CustomerRateCustomModel>> GetCustomerByCustomerIdAsync(int customerID)
        {
            return await RestApiHelper.GetAsync<List<CustomerRateCustomModel>>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}CustomerRateIncreases/{customerID}"));
        }

        public static async Task<DocumentRepository> DownloadDocument(int CustomerAnalysisID)
        {
            return await RestApiHelper.GetAsync<DocumentRepository>(new Uri(UrlHelper.Api.CrmApi, $"Customer/DownloadDocument/{CustomerAnalysisID}"));
        }


    }
}
