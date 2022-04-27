using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data.Branch
{
    public static class BranchServices
    {
        /// <summary>
        /// Returns a List<Branches> from the TritonSecurity.dbo.Branches table
        /// </summary>
        /// <returns>List<Branches></returns>
        public static async Task<List<Branches>> GetAllActiveBranches()
        {
            return await RestApiHelper.GetAsync<List<Branches>>(new Uri(UrlHelper.Api.TritonApi, UrlHelper.Controller.Branch));
        }

        /// <summary>
        /// Get all the branches by the UserId
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Branches</returns>
        public static async Task<Branches> GetByUserId(int userId)
        {
            return await RestApiHelper.GetAsync<Branches>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Branch}{userId}"));
        }

        /// <summary>
        /// Gets a specific branch by the BranchId
        /// </summary>
        /// <param name="branchId"></param>
        /// <returns>Branches</returns>
        public static async Task<Branches> FindBranch(int branchId)
        {
            return await RestApiHelper.GetAsync<Branches>(new Uri(UrlHelper.Api.TritonApiLegacy, $"Branches/GetBranchByID?branchID={branchId}"));
        }

        /// <summary>
        /// Gets a specific branch by the CompanyID
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns>Branches</returns>
        public static async Task<List<Branches>> GetBranchByCompanyID(int? CompanyID)
        {
            return await RestApiHelper.GetAsync<List<Branches>>(new Uri(UrlHelper.Api.TritonApiLegacy, $"Branches/GetAllBranchesByCompanyID?CompanyID={CompanyID}"));
        }
    }
}
