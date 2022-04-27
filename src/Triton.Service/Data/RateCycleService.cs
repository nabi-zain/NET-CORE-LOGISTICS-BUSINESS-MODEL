using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class RateCycleService
    {
        public static async Task<List<RateCycles>> GetAllRateCycles()
        {
            return await RestApiHelper.GetAsync<List<RateCycles>>(new Uri(UrlHelper.Api.RatesApi, $"{UrlHelper.Controller.RateCycle}RateCycles"));
        }
    }
}
