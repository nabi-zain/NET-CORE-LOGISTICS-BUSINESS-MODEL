using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.StoredProcs;
using Triton.Service.Model.CRM.Custom;
using Triton.Service.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class RateIncreaseService
    {
        public static async Task<bool> InsertRateIncreaseAsync(RateIncreases model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RateIncrease}InsertRateIncreaseAsync/Insert"), model);
        }

        public static async Task<bool> UpdateRateIncreaseAsync(RateIncreases model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RateIncrease}UpdateRateIncreaseAsync/Update"), model);
        }

        public static async Task<List<proc_RateIncrease_Select>> GetRateIncreasesPerCycle(int RateCycleID)
        {
            return await RestApiHelper.GetAsync<List<proc_RateIncrease_Select>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RateIncrease}GetRateIncreasesPerCycle/{RateCycleID}"));
        }

        public static async Task<RateIncreases> CheckIfRateIncreaseExist(string RateIncreasePeriod)
        {
            return await RestApiHelper.GetAsync<RateIncreases>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RateIncrease}CheckIfRateIncreaseExist/{RateIncreasePeriod}"));
        }

        public static async Task<List<proc_RateIncrease_Select>> GetRateIncreases()
        {
            return await RestApiHelper.GetAsync<List<proc_RateIncrease_Select>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RateIncrease}GetRateIncreases"));
        }

        public static async Task<proc_RateIncrease_Select> GetRateIncreaseByID(int RateIncreaseID)
        {
            return await RestApiHelper.GetAsync<proc_RateIncrease_Select>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RateIncrease}GetRateIncreaseByID/{RateIncreaseID}"));
        }

        public static async Task<List<CustomerModel>> GetAllCustomers(int WorkFlowStageID)
        {
            return await RestApiHelper.GetAsync<List<CustomerModel>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.CustomerAnalysis}Customers/{WorkFlowStageID}"));
        }

        public static async Task<RateIncreases> RateIncreaseAsync()
        {
            return await RestApiHelper.GetAsync<RateIncreases>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.RateIncrease}RateIncreaseAsync"));
        }

        public static async Task<bool> IsRateIncreaseExitsAsync(int rateIncreaseId)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.CustomerApi, $"{UrlHelper.Controller.RateIncrease}IsRateIncreaseExitsAsync?rateIncreaseId={rateIncreaseId}"));
        }

        public static async Task<RateIncreases> GetTop1RateIncrease()
        {
            return await RestApiHelper.GetAsync<RateIncreases>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RateIncrease}GetTop1RateIncrease"));
        }
    }
}
