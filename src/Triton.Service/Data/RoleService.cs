using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class RoleService
    {
        public static async Task<List<Roles>> GetRolesByUserId(int userId, string dbName)
        {
            //return await _connection.GetAsync<List<Roles>>(StringHelper.Controllers.Users, $"/{StringHelpers.Controllers.Roles}/{userId}/{dbName}");
            return await RestApiHelper.GetAsync<List<Roles>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Roles}/{userId}/{dbName}"));
        }

        /// <summary>
        /// Get a list of Roles using an IN statement in the query for the RoleID's
        /// </summary>
        /// <param name="roleIDs"></param>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public static async Task<List<Roles>> GetRolesByIds(string roleIDs, string dbName)
        {
            //return await _connection.GetAsync<List<Roles>>(StringHelpers.Controllers.Users, $"/{StringHelpers.Controllers.Roles}/{roleIDs}/{dbName}");
            return await RestApiHelper.GetAsync<List<Roles>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Roles}/{roleIDs}/{dbName}"));
        }
    }
}
