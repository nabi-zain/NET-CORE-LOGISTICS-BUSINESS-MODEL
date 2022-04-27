using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CustomerSpecialArrangementService
    {
        public static async Task<CustomerSpecialArangements> GetSpeicalArrangement(int customerID)
        {
            return await RestApiHelper.GetAsync<CustomerSpecialArangements>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}GetSpeicalArrangement?customerID={customerID}"));
        }

        public static async Task<CustomerSpecialArangements> GetSpecialArangementByID(int SpecialArangementID)
        {
            return await RestApiHelper.GetAsync<CustomerSpecialArangements>(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}GetSpecialArangementByID/{SpecialArangementID}"));
        }

        public static async Task<bool> UpdateSpecialArrangement(CustomerSpecialArangements model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}UpdateSpecialArrangement/Update"), model);
        }

        public static async Task<bool> InsertSpecialArrangement(CustomerSpecialArangements model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.CrmApi, $"{UrlHelper.Controller.Customer}InsertSpecialArrangement/Insert"), model);
        }
    }
}
