using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;

using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class RepCodeService
    {
        /// <summary>
        /// Returns a list of repcodes
        /// </summary>
        /// <returns></returns>
        public static async Task<List<RepUsers>> GetActiveReps()
        {
            return await RestApiHelper.GetAsync<List<RepUsers>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.RepCodes}GetActiveReps"));
        }

        /// <summary>
        /// Returns a rep by RepCodeId
        /// </summary>
        /// <param name="repCodeId"></param>
        /// <returns></returns>
        public static async Task<RepUsers> GetById(int repCodeId)
        {
            return await RestApiHelper.GetAsync<RepUsers>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.RepCodes}GetById{repCodeId}"));
        }

        /// <summary>
        /// Post RepCodes
        /// </summary>
        /// <param name="repCodes"></param>
        /// <returns></returns>
        public static async Task<long> PostAsync(RepCodes repCodes)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.RepCodes}PostAsync"), repCodes);
        }

        /// <summary>
        /// Put Async
        /// </summary>
        /// <param name="repCodes"></param>
        /// <returns></returns>
        public static async Task<bool> PutAsync(RepCodes repCodes)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.RepCodes}PostAsync"), repCodes);
        }
    }
}
