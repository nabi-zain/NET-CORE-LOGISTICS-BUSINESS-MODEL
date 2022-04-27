using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using Triton.Model.LeaveManagement.Custom;
using Triton.Model.LeaveManagement.Tables;
using Triton.Service;
using Triton.Service.Model.LeaveManagement.Custom;
using Triton.Service.Utils;

namespace HRM.Recruiment.triton.service.Data
{
    public class JobProfilesService
    {
        public static async Task<List<JobProfiles>> GetAsync(string description)
        {
            return await RestApiHelper.GetAsync<List<JobProfiles>>(new Uri(UrlHelper.Api.RecruitmentApi, $"JobProfile/JobProfiles?description={description}"));
        }

        public static async Task<JobProfiles> GetByIdAsync(int id)
        {
            return await RestApiHelper.GetAsync<JobProfiles>(new Uri(UrlHelper.Api.RecruitmentApi, $"JobProfile/{id}"));
        }

        public static async Task<bool> UpdateAsync(JobProfiles model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"JobProfile/JobProfiles"), model);
        }


        public static async Task<bool> InsertAsync(JobProfiles model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"JobProfile/JobProfiles"), model);
        }

        public static async Task<JobProfilesModel> GetJobProfilesModel()
        {
            return await RestApiHelper.GetAsync<JobProfilesModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"JobProfile/GetJobProfilesModel"));
        }

        public static async Task<bool> FindByDescriptionAsync(JobProfiles jobProfiles)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"JobProfile/FindByDescriptionAsync"), jobProfiles);

        }

        /// <summary>
        /// GetAllJobProfilesAsync - Get all the active Job Profiles
        /// </summary>       
        /// <returns></returns>
        public static async Task<List<JobProfiles>> GetAllJobProfilesAsync()
        {
            return await RestApiHelper.GetAsync<List<JobProfiles>>(new Uri(UrlHelper.Api.RecruitmentApi, $"JobProfile/GetAllJobProfilesAsync"));
        }

        public static async Task<JobProfile_OFOCode_CustomModel> GetJobProfilesByEmployeeIDAsync(int employeeId)
        {
            return await RestApiHelper.GetAsync<JobProfile_OFOCode_CustomModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"JobProfile/GetJobProfilesByEmployeeIDAsync?employeeId={employeeId}"));
        }
    }
}
