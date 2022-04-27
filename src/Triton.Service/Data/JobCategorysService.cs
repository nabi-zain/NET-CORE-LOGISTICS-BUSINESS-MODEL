using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.LeaveManagement.Tables;
using Triton.Service;
using Triton.Service.Utils;

namespace HRM.Recruiment.triton.service.Data
{
    public class JobCategorysService
    {
        public static async Task<List<JobCategorys>> GetAsync()
        {
            return await RestApiHelper.GetAsync<List<JobCategorys>>(new Uri(UrlHelper.Api.RecruitmentApi, $"JobCategory/JobCategorys"));
        }

        public static async Task<JobCategorys> GetByIdAsync(int id)
        {
            return await RestApiHelper.GetAsync<JobCategorys>(new Uri(UrlHelper.Api.RecruitmentApi, $"JobCategory/{id}"));
        }

        public static async Task<bool> UpdateAsync(JobCategorys model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"JobCategory/JobCategorys"), model);
        }

        public static async Task<bool> InsertAsync(JobCategorys model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"JobCategory/JobCategorys"), model);
        }

        public static async Task<JobCategorys> FindByDescription(string description)
        {
            return await RestApiHelper.GetAsync<JobCategorys>(new Uri(UrlHelper.Api.RecruitmentApi, $"JobCategory/{description}"));
        }
    }
}
