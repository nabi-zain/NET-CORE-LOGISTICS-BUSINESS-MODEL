using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Custom;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CountryCurrencySpotService
    {
        public static async Task<List<CountryCurrencySpotsModel>> GetAsync()
        {
            return await RestApiHelper.GetAsync<List<CountryCurrencySpotsModel>>(new Uri(UrlHelper.Api.TritonApi, $"Country/CountryCurrencySpots"));
        }


        public static async Task<bool> UpdateAsync(List<CountryCurrencySpots> CountryCurrencySpotList)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"Country/CountryCurrencySpots"), CountryCurrencySpotList);
        }
    }
}
