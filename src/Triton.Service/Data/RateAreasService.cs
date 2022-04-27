using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class RateAreasService
    {
        public static async Task<bool> InsertAsync(RateAreas model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.TritonApi, $"RateAreas"), model);
        }
        public static async Task<RateAreas> FindByDescriptionAndShortCode(string description, string shortCode)
        {
            return await RestApiHelper.GetAsync<RateAreas>(new Uri(UrlHelper.Api.TritonApi, $"RateAreas/FindByDescriptionAndShortCode?description=" + description + "&shortCode=" + shortCode));
        }

        public static async Task<List<RateAreas>> SearchByShortCode(string shortCode)
        {
            return await RestApiHelper.GetAsync<List<RateAreas>>(new Uri(UrlHelper.Api.TritonApi, $"RateAreas/SearchByShortCode/" + shortCode));
        }
    }
}
