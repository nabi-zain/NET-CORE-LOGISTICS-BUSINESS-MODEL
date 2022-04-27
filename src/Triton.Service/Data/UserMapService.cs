using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Custom;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public static class UserMapService
    {
        /// <summary>
        /// Get a record from the UserMap table by passing in the UserMapId
        /// </summary>
        /// <param name="userMapId"></param>
        /// <returns>Returns an object of type UserMap</returns>
        public static async Task<UserMap> GetUserMap(int userMapId)
        {
            return await RestApiHelper.GetAsync<UserMap>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.UserMap}{userMapId}"));
        }

        /// <summary>
        /// Get a list of users based on the user type (userTypeLcid)
        /// </summary>
        /// <param name="userTypeLcid"></param>
        /// <returns>Returns a List of Users</returns>
        public static async Task<List<UserMap>>GetUserMapByUserType(int userTypeLcid)
        {
            return await RestApiHelper.GetAsync<List<UserMap>>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.UserMap}{userTypeLcid}"));
        }

        /// <summary>
        /// Get the UserMap with Customers object
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Returns a list of UserMaps and Customers</returns>
        public static async Task<UserMapCustomerModels>GetUserCustomerMapModel(int userId)
        {
            return await RestApiHelper.GetAsync<UserMapCustomerModels>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.UserMap}{userId}"));
        }

        /// <summary>
        /// Insert a new record into the UserMap table
        /// </summary>
        /// <param name="userMap"></param>
        /// <returns>Returns a string eg:  Duplicate Employee, Invalid UserTypeLCID, Created etc...</returns>
        public static async Task<string> PostUserMapObject(UserMap userMap)
        {
            return await RestApiHelper.PostAsyncString(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.UserMap}"), userMap);
        }

        /// <summary>
        /// Update an existing record in the UserMap table
        /// </summary>
        /// <param name="userMap"></param>
        /// <returns></returns>
        public static async Task<bool>PutUserMap(UserMap userMap)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.UserMap}"), userMap);
        }
    }
}
