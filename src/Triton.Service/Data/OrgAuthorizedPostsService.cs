using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.LeaveManagement.Custom;
using Triton.Service.Model.LeaveManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class OrgAuthorizedPostsService
    {
        public static async Task<List<AllAuthorizedPostsModel>> GetAllAuthorizedPostsByStatus(bool authActive)
        {
            return await RestApiHelper.GetAsync<List<AllAuthorizedPostsModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.AllAuthorizedPosts}GetAllAuthorizedPostsByStatus/{authActive}"));
        }

        public static async Task<AllAuthorizedPostsModel> GetAuthorizedPostsByID(int authCodeId)
        {
            return await RestApiHelper.GetAsync<AllAuthorizedPostsModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.AllAuthorizedPosts}GetAuthorizedPostsByID/{authCodeId}"));
        }

        public static async Task<bool> UpdateAuthorizedPost(orgAuthorizedPosts model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.AllAuthorizedPosts}UpdateAuthorizedPost/Update"), model);
        }
    }
}
