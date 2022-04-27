using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Custom;
using Triton.Model.Applications.Tables;
using Triton.Model.TritonSecurity.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class ClaimsService
    {
        public static async Task<long> InsertUserAsync(tblUsers model)
        {
            return await RestApiHelper.PostAsyncLong(new Uri(UrlHelper.Api.ClaimsApi, $"{UrlHelper.Controller.Claims}InsertUserAsync/Insert"), model);
        }

        public static async Task<bool> UpdateUserAsync(tblUsers model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.ClaimsApi, $"{UrlHelper.Controller.Claims}UpdateUserAsync/Update"), model);
        }

        public static async Task<List<tblUserModel>> GetUsers()
        {
            return await RestApiHelper.GetAsync<List<tblUserModel>>(new Uri(UrlHelper.Api.ClaimsApi, $"{UrlHelper.Controller.Claims}Users"));
        }

        public static async Task<BranchUserDepartmentsModel> GetBranchesUsersDepartments(string Name)
        {
            return await RestApiHelper.GetAsync<BranchUserDepartmentsModel>(new Uri(UrlHelper.Api.ClaimsApi, $"{UrlHelper.Controller.Claims}BranchesUsersDepartments/{Name}"));
        }

        public static async Task<tblUsers> GetApplicationUserByID(int UserID)
        {
            return await RestApiHelper.GetAsync<tblUsers>(new Uri(UrlHelper.Api.ClaimsApi, $"{UrlHelper.Controller.Claims}GetApplicationUserByID/{UserID}"));
        }

        public static async Task<tblUsers> GetUserNameByID(string Username)
        {
            return await RestApiHelper.GetAsync<tblUsers>(new Uri(UrlHelper.Api.ClaimsApi, $"{UrlHelper.Controller.Claims}GetUserNameByID/{Username}"));
        }

        public static async Task<tblUsers> GetEmailAddressIfExists(string EmailAddress)
        {
            return await RestApiHelper.GetAsync<tblUsers>(new Uri(UrlHelper.Api.ClaimsApi, $"{UrlHelper.Controller.Claims}GetEmailAddressIfExists/{EmailAddress}"));
        }
    }
}
