using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Service.Model.HRM.Custom;
using Triton.Service.Model.HRM.StoredProcs;
using Triton.Service.Model.HRM.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class RecruitmentService
    {
        public static async Task<bool> InsertAsync(Recruitment recruitment)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Recruitment}InsertAsync"), recruitment);
        }

        public static async Task<List<RecruitmentCustomModel>> GetAllAsync(int stageId)
        {
            return await RestApiHelper.GetAsync<List<RecruitmentCustomModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Recruitment}GetAllAsync?stageId={stageId}"));
        }

        public static async Task<RecruitmentCustomModel> GetByIdAsync(int recruitmentId)
        {
            return await RestApiHelper.GetAsync<RecruitmentCustomModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Recruitment}GetByIdAsync?recruitmentId={recruitmentId}"));
        }

        public static async Task<bool> UpdateAsync(Recruitment recruitment)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Recruitment}UpdateAsync"), recruitment);
        }

        public static async Task<List<proc_HRM_Tabs>> HRMTabsAsync()
        {
            return await RestApiHelper.GetAsync<List<proc_HRM_Tabs>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.Recruitment}HRMTabsAsync"));
        }

    }
}
