using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.TritonGroup.Custom;
using Triton.Service.Model.TritonGroup.StoredProcs;
using Triton.Service.Model.TritonGroup.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class UserBranchService
    {
        public static async Task<List<proc_UserBranch_Summary>> GetAllAsync()
        {
            return await RestApiHelper.GetAsync<List<proc_UserBranch_Summary>>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserBranch}GetAllAsync"));
        }

        public static async Task<bool> InsertAsync(List<UserBranch> userBranches)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserBranch}InsertAsync"), userBranches);
        }

        public static async Task<proc_UserBranches_IsBranchesExists> IsBrancExistsAsync(int userId, string branches)
        {
            return await RestApiHelper.GetAsync<proc_UserBranches_IsBranchesExists>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserBranch}IsBrancExistsAsync?userId={userId}&branches={branches}"));
        }

        public static async Task<UserBranchModel> GetByIdAsync(int userId)
        {
            return await RestApiHelper.GetAsync<UserBranchModel>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserBranch}GetByIdAsync?userId={userId}"));
        }

        public static async Task<bool> UpdateAsync(List<UserBranch> userBranches)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserBranch}UpdateAsync"), userBranches);
        }

    }
}
