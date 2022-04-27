using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Service.Model.LeaveManagement.Custom;
using Triton.Service.Model.LeaveManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class OFOJobProfileService
    {
        public static async Task<List<OFOJobProfile>> GetOFOJobProfiles()
        {
            return await RestApiHelper.GetAsync<List<OFOJobProfile>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOJobProfile}GetOFOJobProfiles"));
        }

        public static async Task<List<OFOJobProfileModel>> GetOFOJobProfilesByID(int OFOCodeID)
        {
            return await RestApiHelper.GetAsync<List<OFOJobProfileModel>>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOJobProfile}GetOFOJobProfilesByID?OFOCodeID={OFOCodeID}"));
        }

        public static async Task<OFOJobProfileModel> GetOFOJobProfilesByJobProfileID(int OFOJobProfileID)
        {
            return await RestApiHelper.GetAsync<OFOJobProfileModel>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOJobProfile}GetOFOJobProfilesByJobProfileID?OFOJobProfileID={OFOJobProfileID}"));
        }

        public static async Task<bool> InsertOFOJobProfileAsync(OFOJobProfile model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOJobProfile}InsertOFOJobProfileAsync/Insert"), model);
        }

        public static async Task<bool> UpdateOFOJobProfileAsync(OFOJobProfile model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOJobProfile}UpdateOFOJobProfileAsync/Update"), model);
        }

        public static async Task<bool> DeleteOFOJobProfileAsync(OFOJobProfile model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOJobProfile}DeleteOFOJobProfileAsync/Update"), model);
        }

        public static async Task<OFOJobProfile> CheckDuplicateJobProfile(int OFOSpecializationID, int JobProfileID, int OFOCodeID)
        {
            return await RestApiHelper.GetAsync<OFOJobProfile>(new Uri(UrlHelper.Api.RecruitmentApi, $"{UrlHelper.Controller.OFOJobProfile}CheckDuplicateJobProfile?OFOSpecializationID={OFOSpecializationID}&JobProfileID={JobProfileID}&OFOCodeID={OFOCodeID}"));
        }
    }
}
