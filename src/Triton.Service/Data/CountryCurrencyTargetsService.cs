using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Service;
using Triton.Service.Utils;

namespace Triton.CRM.triton.service.Data
{
    public class CountryCurrencyTargetsService
    {
        public static async Task<List<CountryCurrencyTargetsModel>> GetAsync()
        {
            return await RestApiHelper.GetAsync<List<CountryCurrencyTargetsModel>>(new Uri(UrlHelper.Api.SalesApi, "CountryCurrencyTargets/CountryCurrencyTargets"));
        }
        public static async Task<CountryCurrencyTargetsModel> GetByIdAsync(int id)
        {
            return await RestApiHelper.GetAsync<CountryCurrencyTargetsModel>(new Uri(UrlHelper.Api.SalesApi, $"CountryCurrencyTargets/{id}"));
        }

        public static async Task<bool> UpdateAsync(CountryCurrencyTargets model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.SalesApi, $"CountryCurrencyTargets/CountryCurrencyTargets"), model);
        }

        public static async Task<bool> InsertAsync(List<CountryCurrencyTargets> model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.SalesApi, $"CountryCurrencyTargets/CountryCurrencyTargets"), model);
        }
        public static async Task<bool> IsMonthAndYearExistsAsync(int calMonth, int calYear)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.SalesApi, $"CountryCurrencyTargets/IsMonthAndYearExists?calMonth={calMonth}&calYear={calYear}"));
        }

        public static async Task<CountryCurrencyTargetsModel> CurrentAndFutureCalMonthAndCalYear()
        {
            return await RestApiHelper.GetAsync<CountryCurrencyTargetsModel>(new Uri(UrlHelper.Api.SalesApi, $"CountryCurrencyTargets/CurrentAndFutureCalMonthAndCalYear"));
        }
    }
}
