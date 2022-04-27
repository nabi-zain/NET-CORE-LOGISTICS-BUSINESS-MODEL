using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CustomerUniqueRateService
    {
        public static async Task<long> GetAsync(string accountCode, string isActive)
        {
            return await RestApiHelper.GetAsync<long>(new Uri(UrlHelper.Api.Freightware, $"Rate?accountCode={accountCode}&isActive={isActive}"));
        }

        public static async Task<List<proc_Rates_Outlying_SlidingScale_Select>> GetOutlyingSlidingRates(int customerId)
        {
            return await RestApiHelper.GetAsync<List<proc_Rates_Outlying_SlidingScale_Select>>(new Uri(UrlHelper.Api.RatesApi, $"CustomerUniqueRate/GetOutlyingSlidingRates/{customerId}"));
        }

        public static async Task<List<CustomerUniqueRates>> GetCustomerUniqueRateAsync(int customerId)
        {
            return await RestApiHelper.GetAsync<List<CustomerUniqueRates>>(new Uri(UrlHelper.Api.RatesApi, $"CustomerUniqueRate/GetCustomerUniqueRateAsync?customerId={customerId}"));
        }
    }
}
