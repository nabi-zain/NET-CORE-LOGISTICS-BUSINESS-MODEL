using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.TritonGroup.StoredProcs;
using Triton.Service.Model.TritonOps.StoredProcs;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class CustomerServiceAgentService
    {
        public static async Task<List<proc_CSA_GetByUserID>> FindCSAByUserIdAsync(int userId, DateTime startDate, DateTime endDate)
        {
            return await RestApiHelper.GetAsync<List<proc_CSA_GetByUserID>>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.CustomerServiceAgent}FindCSAByUserIdAsync?userId={userId}&startDate={startDate}&endDate={endDate}"));
        }

        public static async Task<proc_PreviousDay_Holidays_Select> PreviousDayAsync(DateTime startDate, DateTime endDate)
        {
            return await RestApiHelper.GetAsync<proc_PreviousDay_Holidays_Select>(new Uri(UrlHelper.Api.Waybill, $"{UrlHelper.Controller.CustomerServiceAgent}PreviousDayAsync?startDate={startDate}&endDate={endDate}"));
        }
    }
}
