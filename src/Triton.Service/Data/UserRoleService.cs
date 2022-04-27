using System;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class UserRoleService
    {
        /// <summary>
        /// Gets the UserRoles by UserRoleID
        /// </summary>
        /// <param name="userRoleId"></param>
        /// <returns>Returns a single UserRole</returns>
        public static async Task<UserRoles> GetUserRole(int userRoleId)
        {
            return await RestApiHelper.GetAsync<UserRoles>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.UserRoles}{userRoleId}"));
        }

        public static async Task<long>PostAsync(UserRoles model, string dbName)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.UserRoles}/{dbName}"), model);
        }

        public static async Task<bool>PutAsync(UserRoles model, string dbName)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.UserRoles}/{dbName}"), model);
        }
    }
}
