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
    public class UserRoleGroupService
    {
        public static async Task<List<proc_UserRoleGroup_Summary>> GetAllAsync()
        {
            return await RestApiHelper.GetAsync<List<proc_UserRoleGroup_Summary>>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserRoleGroup}GetAllAsync"));
        }

        public static async Task<UserRoleGroupModel> FindUserRoleGroupByIdAsync(int userRoleGroupId)
        {
            return await RestApiHelper.GetAsync<UserRoleGroupModel>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserRoleGroup}GetByIdAsync?userRoleGroupId={userRoleGroupId}"));
        }

        public static async Task<bool> IsUserNameExistsAsync(int userId, int roleGroupID = 0)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserRoleGroup}IsUserNameExistsAsync?userId={userId}&roleGroupID={roleGroupID}"));
        }

        public static async Task<UserRoleGroupModel> GetByIdAsync(int userId, int systemId)
        {
            return await RestApiHelper.GetAsync<UserRoleGroupModel>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserRoleGroup}GetByIdAsync?userId={userId}&systemId={systemId}"));
        }

        public static async Task<bool> UpdateAsync(UserRoleGroup userRoleGroup)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserRoleGroup}UpdateAsync"), userRoleGroup);
        }

        public static async Task<bool> InsertAsync(UserRoleGroup userRoleGroup)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.UserRoleGroup}InsertAsync"), userRoleGroup);
        }

    }
}
