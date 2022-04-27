using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.TritonGroup.StoredProcs;
using Triton.Service.Model.TritonGroup.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class RoleGroupService
    {
        public static async Task<List<proc_RoleGroup_Select>> GetAllAsync(int systemId)
        {
            return await RestApiHelper.GetAsync<List<proc_RoleGroup_Select>>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.RoleGroup}GetAllAsync?systemId={systemId}"));
        }
        public static async Task<RoleGroup> FindRoleGroupByIdAsync(int roleGroupId)
        {
            return await RestApiHelper.GetAsync<RoleGroup>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.RoleGroup}GetByIdAsync?roleGroupId={roleGroupId}"));
        }

        public static async Task<bool> IsRoleNameExistsAsync(string roleName, int systemId = 0)
        {
            return await RestApiHelper.GetAsync<bool>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.RoleGroup}IsRoleNameExistsAsync?roleName={roleName}&systemId={systemId}"));
        }

        public static async Task<bool> UpdateAsync(RoleGroup roleGroup)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.RoleGroup}UpdateAsync"), roleGroup);
        }

        public static async Task<bool> InsertAsync(RoleGroup roleGroup)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"{UrlHelper.Controller.RoleGroup}InsertAsync"), roleGroup);
        }
    }
}
