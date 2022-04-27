using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Custom;
using Triton.Model.CRM.Tables;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class CRMDashBoardService
    {
        /// <summary>
        /// Returns a list of all active reps
        /// </summary>
        /// <returns></returns>
        public static async Task<List<RepUserModel>> RepNames()
        {
            return await RestApiHelper.GetAsync<List<RepUserModel>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CRMDashBoard}GetRepNames"));
        }

        /// <summary>
        /// Returns all the different account types
        /// </summary>
        /// <returns></returns>
        public static async Task<List<CustomerAccountTypes>>CustomerAccount()
        {
            return await RestApiHelper.GetAsync<List<CustomerAccountTypes>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CRMDashBoard}CustomerAccount"));
        }

        /// <summary>
        /// Returns a list of Vertical markets
        /// </summary>
        /// <returns></returns>
        public static async Task<List<VerticalMarkets>>VerticalMarkets()
        {
            return await RestApiHelper.GetAsync<List<VerticalMarkets>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CRMDashBoard}RepsGetVerticalMarkets"));
        }

        /// <summary>
        /// Returns a list of branches
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Branches>> CRMBranches()
        {
            return await RestApiHelper.GetAsync<List<Branches>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.CRMDashBoard}CRMBRanches"));
        }
    }
}
