using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class RateService
    {
        public static async Task<List<proc_Rates_Matrix_Select>> GetRatesMatrixAsync(int CustomerID, int RateYear, bool? isCrossBorder = false)
        {
            return await RestApiHelper.GetAsync<List<proc_Rates_Matrix_Select>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.Rate}GetRatesMatrixAsync/{CustomerID}/{RateYear}/{isCrossBorder}"));
        }

        public static async Task<List<RateDirections>> GetRateDirectionAsync()
        {
            return await RestApiHelper.GetAsync<List<RateDirections>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RateDirection}"));
        }

        public static async Task<int> GetActiveRateYear()
        {
            return await RestApiHelper.GetAsync<int>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.Rate}GetRateYear"));
        }

        public static async Task<int> GetLatestRateYear()
        {
            return await RestApiHelper.GetAsync<int>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.Rate}GetLatestRateYear"));
        }
    }
}
