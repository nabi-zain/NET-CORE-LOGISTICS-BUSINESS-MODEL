using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Custom;
using Triton.Model.TritonGroup.StoredProcs;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonSecurity.Tables;
using Triton.Service.Model.TritonGroup.StoredProcs;
using Triton.Service.Utils;
using Users = Triton.Model.TritonSecurity.Tables.Users;

namespace Triton.Service.Data
{
    public static class UserService
    {
        /// <summary>
        /// Gets the user by their username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Returns a single user</returns>
        public static async Task<Users>FindByNameAsync(string username)
        {
            return await RestApiHelper.GetAsync<Users>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Users}{username}"));
        }

        /// <summary>
        /// Creates a new user and returns the user object
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns a user object</returns>
        public static async Task<bool>CreateAsync<T>(Users model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Users}"), model);
        }

        /// <summary>
        /// Creates a new user and returns a UserID
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns a UserID</returns>
        public static async Task<long>Post(Users model)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Users}"), model);
        }

        /// <summary>
        /// Updates an existing user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns a boolean</returns>
        public static async Task<bool>PutUpdateAsync(Users model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Users}"), model);
        }

        /// <summary>
        /// Gets the user by their UserID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>Returns a single user</returns>
        public static async Task<Users>FindByIdAsync(int userId)
        {
            return await RestApiHelper.GetAsync<Users>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Users}{userId}"));
        }

        /// <summary>
        /// Gets all the users including locked out users
        /// </summary>
        /// <returns>Returns a list of users</returns>
        public static async Task<Users>GetAllUsersInclLockedOut<T>()
        {
            return await RestApiHelper.GetAsync<Users>(new Uri($"{UrlHelper.Controller.Users}"));
        }

        /// <summary>
        /// Gets the User/UserRoles and Roles for creating views
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleIds"></param>
        /// <returns>Returns a UserWithRoles model</returns>
        public static async Task<UserWithRoles> GetUserWithRoles(int userId, string roleIds)
        {
            return await RestApiHelper.GetAsync<UserWithRoles>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Users}{userId}/{roleIds}"));
        }

        /// <summary>
        /// Get all the user information with branches / roles / employees
        /// </summary>
        /// <param name="sAmAccountName"></param>
        /// <param name="database"></param>
        /// <returns></returns>
        public static async Task<UserInformation> FindBysAmAccountName(string sAmAccountName, string database)
        {
            return await RestApiHelper.GetAsync<UserInformation>(new Uri(UrlHelper.Api.TritonApi, $"{UrlHelper.Controller.Users}{sAmAccountName}/{database}"));
        }

        public static async Task<UserInformation> FindBysAmAccountName(string sAmAccountName, int systemID)
        {
           return await RestApiHelper.GetAsync<UserInformation>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"Users/FindBysAmAccountNameAsync?sAmAccountName={sAmAccountName}&systemID={systemID}"));
        }

        public static async Task<List<proc_Users_Summary>> GetAllAsync()
        {
            return await RestApiHelper.GetAsync<List<proc_Users_Summary>>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"Users/GetAllAsync"));
        }

        public static async Task<List<Users>> GetActiveCreditSupervisorAsync()
        {
            return await RestApiHelper.GetAsync<List<Users>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.Users}GetActiveCreditSupervisorAsync"));
        }

        public static async Task<List<proc_Users_Summary>> GetAllBySystemIdAsync(int systemId)
        {
            return await RestApiHelper.GetAsync<List<proc_Users_Summary>>(new Uri(UrlHelper.Api.TritonSecurityCommonApi, $"Users/GetAllBySystemIdAsync?systemId={systemId}"));
        }
    }
}
